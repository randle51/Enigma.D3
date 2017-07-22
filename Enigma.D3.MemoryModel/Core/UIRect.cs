using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public struct UIRect
    {
        public static UIRect Empty = new UIRect();

        public float Left;
        public float Top;
        public float Right;
        public float Bottom;

        public float Width { get { return Right - Left; } }
        public float Height { get { return Bottom - Top; } }

        public override string ToString()
        {
            return string.Format("{0} x {1} - L: {2}, T: {3}, R: {4}, B: {5}", Width, Height, Left, Top, Right, Bottom);
        }

        /// <summary>
        /// This is just an example, change type to fit whatever UI system you're using for rendering.
        /// WinForm uses pixels (int) while WPF uses DPI (float).
        /// </summary>
        public UIRect TranslateToClientRect(float clientWidth, float clientHeight)
        {
            // All sizes/positions are based on a Root of height 1200. Its width will depend on
            // what aspect ratio the window (client) currently has.
            const float normalizedHeight = 1200.0f;

            var aspectRatio = clientWidth / clientHeight;
            var uiScale = clientHeight / normalizedHeight;
            var uiRootWidth = aspectRatio * normalizedHeight;
            var uiRootHeight = normalizedHeight;

            // An offset is applied to the horizontal axis in order to compensate for aspect ratio
            // changes. You can see the base is UIRoot width for 4:3 ratio.
            var horizontalOffset = (float)((int)((uiRootHeight * 4f / 3f) - uiRootWidth) >> 1);

            var clientRect = new UIRect();
            clientRect.Left = (Left - horizontalOffset) * uiScale;
            clientRect.Top = (Top * uiScale);
            clientRect.Right = clientRect.Left + (Width * uiScale);
            clientRect.Bottom = clientRect.Top + (Height * uiScale);
            return clientRect;
        }
    }
}
