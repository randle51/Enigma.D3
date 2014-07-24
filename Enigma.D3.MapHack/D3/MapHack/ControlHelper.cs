using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Enigma.D3.MapHack
{
	public static class ControlHelper
	{
		public static Shape SetOpacity(this Shape shape, double opacity)
		{
			shape.Opacity = opacity;
			return shape;
		}

		public static Shape AnimateOpacity(this Shape shape, double fromValue, double toValue, double durationInSeconds)
		{
			return shape.AnimateOpacity(fromValue, toValue, TimeSpan.FromSeconds(durationInSeconds));
		}

		public static Shape AnimateOpacity(this Shape shape, double fromValue, double toValue, TimeSpan duration)
		{
			shape.BeginAnimation(FrameworkElement.OpacityProperty, new DoubleAnimation(fromValue, toValue, new Duration(duration)) { RepeatBehavior = RepeatBehavior.Forever, AutoReverse = true });
			return shape;
		}

		public static Shape AnimateScale(this Shape shape, double fromValue, double toValue, double durationInSeconds)
		{
			return shape.AnimateScale(fromValue, toValue, TimeSpan.FromSeconds(durationInSeconds));
		}

		public static Shape AnimateScale(this Shape shape, double fromValue, double toValue, TimeSpan duration)
		{
			var scale = new ScaleTransform(fromValue, fromValue);
			shape.AddRenderTransform(scale);
			scale.BeginAnimation(ScaleTransform.ScaleXProperty, new DoubleAnimation(fromValue, toValue, new Duration(duration)) { RepeatBehavior = RepeatBehavior.Forever, AutoReverse = true });
			scale.BeginAnimation(ScaleTransform.ScaleYProperty, new DoubleAnimation(fromValue, toValue, new Duration(duration)) { RepeatBehavior = RepeatBehavior.Forever, AutoReverse = true });
			return shape;
		}

		public static Shape SpinRight(this Shape shape, double revolutionsPerSecond)
		{
			return shape.AnimateRotation(0, -360, 1d / revolutionsPerSecond, false);
		}

		public static Shape SpinLeft(this Shape shape, double revolutionsPerSecond)
		{
			return shape.AnimateRotation(0, 360, 1d / revolutionsPerSecond, false);
		}

		public static Shape AnimateRotation(this Shape shape, double fromAngle, double toAngle, double durationInSeconds, bool autoReverse = false)
		{
			return shape.AnimateRotation(fromAngle, toAngle, TimeSpan.FromSeconds(durationInSeconds));
		}

		public static Shape AnimateRotation(this Shape shape, double fromAngle, double toAngle, TimeSpan duration, bool autoReverse = false)
		{
			var scale = new RotateTransform(fromAngle);
			shape.AddRenderTransform(scale);
			scale.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(fromAngle, toAngle, new Duration(duration)) { RepeatBehavior = RepeatBehavior.Forever, AutoReverse = autoReverse });
			scale.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(fromAngle, toAngle, new Duration(duration)) { RepeatBehavior = RepeatBehavior.Forever, AutoReverse = autoReverse });
			return shape;
		}

		public static void AddLayoutTransform(this Shape shape, Transform transform)
		{
			if (shape.LayoutTransform == null)
			{
				shape.LayoutTransform = transform;
			}
			else
			{
				var group = shape.LayoutTransform as TransformGroup;
				if (group == null)
				{
					group = new TransformGroup();
					group.Children.Add(shape.RenderTransform);
				}
				group.Children.Add(transform);
				shape.LayoutTransform = group;
			}
		}

		public static void AddRenderTransform(this Shape shape, Transform transform)
		{
			if (shape.RenderTransform == null)
			{
				shape.RenderTransform = transform;
			}
			else
			{
				var group = shape.RenderTransform as TransformGroup;
				if (group == null)
				{
					group = new TransformGroup();
					group.Children.Add(shape.RenderTransform);
				}
				group.Children.Add(transform);
				shape.RenderTransform = group;
			}
		}


		public static Shape If(this Shape shape, bool condition, Func<Shape, Shape> func)
		{
			if (condition)
				return func.Invoke(shape);
			return shape;
		}

		public static Shape Do(this Shape shape, Action<Shape> func)
		{
			func.Invoke(shape);
			return shape;
		}


		public static Shape BindVisibilityTo<T>(this Shape shape, T source, Expression<Func<T,bool>> propertySelector)
		{
			var memberExpression = propertySelector.Body as MemberExpression;
			var propertyName = memberExpression.Member.Name;
			BindingOperations.SetBinding(shape, FrameworkElement.VisibilityProperty, new Binding(propertyName) { Source = source, Converter = new BooleanToVisibilityConverter() });
			return shape;
		}


		public static Ellipse CreateCircle(double diameter, Brush fill, Brush stroke = null, double strokeThickness = double.NaN)
		{
			diameter -= strokeThickness / 2;

			var control = new Ellipse();
			control.BeginInit();

			control.Width = diameter;
			control.Height = diameter;
			control.Stroke = stroke;
			control.StrokeThickness = strokeThickness;
			control.Fill = fill;

			var translateTransform = new TranslateTransform();
			BindingOperations.SetBinding(translateTransform, TranslateTransform.XProperty, new Binding() { Source = control, Path = new PropertyPath(Ellipse.ActualWidthProperty), Converter = new HalfConverter() });
			BindingOperations.SetBinding(translateTransform, TranslateTransform.YProperty, new Binding() { Source = control, Path = new PropertyPath(Ellipse.ActualHeightProperty), Converter = new HalfConverter() });
			control.RenderTransform = new TransformGroup
			{
				Children = new TransformCollection { translateTransform }
			};

			control.EndInit();
			return control;
		}

		public static Path CreateCross(double size, Brush stroke, double strokeThickness)
		{
			var geometry = new PathGeometry(new[]
			{ 
				new PathFigure(new Point(0, size / 2), new[] { new LineSegment(new Point(size, size / 2), true) }, false),
				new PathFigure(new Point(size / 2, 0), new[] { new LineSegment(new Point(size / 2, size), true) }, false)
			});
			return new Path() { Data = geometry, StrokeThickness = strokeThickness, Stroke = stroke, RenderTransform = new TranslateTransform(-size / 2, -size / 2) };
		}

		public static SolidColorBrush CreateAnimatedBrush(Color fromValue, Color toValue, double durationInSeconds)
		{
			return CreateAnimatedBrush(fromValue, toValue, TimeSpan.FromSeconds(durationInSeconds));
		}

		public static SolidColorBrush CreateAnimatedBrush(Color fromValue, Color toValue, TimeSpan duration)
		{
			var brush = new SolidColorBrush(Colors.Purple);
			brush.BeginAnimation(SolidColorBrush.ColorProperty, new ColorAnimation(fromValue, toValue, new Duration(duration)) { RepeatBehavior = RepeatBehavior.Forever, AutoReverse = true });
			return brush;
		}
	}
}
