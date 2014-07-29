using System;
using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public struct Acceleration
	{
		public static implicit operator float(Acceleration acceleration)
		{
			return acceleration.Value;
		}
		
		public static implicit operator Acceleration(float value)
		{
			return new Acceleration { Value = value };
		}
		
		public float Value;
		
		public override string ToString()
		{
			return (Value * 3600.0f).ToString("0.00") + " ft/s^2";
		}
	}
	
	[CompilerGenerated]
	public struct Angle
	{
		public const float RadianToDegree = 180f / (float)Math.PI; //57.295776f;
		
		public static implicit operator float(Angle angle)
		{
			return angle.Value;
		}
		
		public static implicit operator Angle(float value)
		{
			return new Angle { Value = value };
		}
		
		public float Value;
		
		public override string ToString()
		{
			return (Value * RadianToDegree).ToString("0.00") + "-|";
		}
	}
	
	[CompilerGenerated]
	public struct AngularVelocity
	{
		public const float RadianToDegree = 180f / (float)Math.PI; //57.295776f;
		
		public static implicit operator float(AngularVelocity angularVelocity)
		{
			return angularVelocity.Value;
		}
		
		public static implicit operator AngularVelocity(float value)
		{
			return new AngularVelocity { Value = value };
		}
		
		public float Value;
		
		public override string ToString()
		{
			return ((Value * RadianToDegree) * 60.0f).ToString("0.00") + "-|/s";
		}
	}
	
	[CompilerGenerated]
	public struct AttributeParameter
	{
		public static implicit operator int(AttributeParameter attributeParameter)
		{
			return attributeParameter.Value;
		}
		
		public static implicit operator AttributeParameter(int value)
		{
			return new AttributeParameter { Value = value };
		}
		
		public int Value;
		
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
	[CompilerGenerated]
	public struct DataId
	{
		public static implicit operator int(DataId dataId)
		{
			return dataId.Value;
		}
		
		public static implicit operator DataId(int value)
		{
			return new DataId { Value = value };
		}
		
		public int Value;
		
		public override string ToString()
		{
			return "0x" + Value.ToString("X8");
		}
	}
	
	[CompilerGenerated]
	public struct GameBalanceId
	{
		public static implicit operator int(GameBalanceId gameBalanceId)
		{
			return gameBalanceId.Value;
		}
		
		public static implicit operator GameBalanceId(int value)
		{
			return new GameBalanceId { Value = value };
		}
		
		public int Value;
		
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
	[CompilerGenerated]
	public struct HighPrecisionPercent
	{
		public static implicit operator float(HighPrecisionPercent highPrecisionPercent)
		{
			return highPrecisionPercent.Value;
		}
		
		public static implicit operator HighPrecisionPercent(float value)
		{
			return new HighPrecisionPercent { Value = value };
		}
		
		public float Value;
		
		public override string ToString()
		{
			return (Value * 100.0f).ToString("0.0000") + "%";
		}
	}
	
	[CompilerGenerated]
	public struct Impulse
	{
		public static implicit operator float(Impulse impulse)
		{
			return impulse.Value;
		}
		
		public static implicit operator Impulse(float value)
		{
			return new Impulse { Value = value };
		}
		
		public float Value;
		
		public override string ToString()
		{
			return (Value * 60.0f).ToString("0.00") + " lb-sec";
		}
	}
	
	[CompilerGenerated]
	public struct Mass
	{
		public static implicit operator float(Mass mass)
		{
			return mass.Value;
		}
		
		public static implicit operator Mass(float value)
		{
			return new Mass { Value = value };
		}
		
		public float Value;
		
		public override string ToString()
		{
			return (Value * 32.2f).ToString("0.00") + " lb";
		}
	}
	
	[CompilerGenerated]
	public struct Percent
	{
		public static implicit operator byte(Percent percent)
		{
			return percent.Value;
		}
		
		public static implicit operator Percent(byte value)
		{
			return new Percent { Value = value };
		}
		
		public byte Value;
		
		public override string ToString()
		{
			return (((float)Value / 255.0f) * 100.0f).ToString("0.00") + "%";
		}
	}
	
	[CompilerGenerated]
	public struct Sno
	{
		public static implicit operator int(Sno sno)
		{
			return sno.Value;
		}
		
		public static implicit operator Sno(int value)
		{
			return new Sno { Value = value };
		}
		
		public int Value;
		
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
	[CompilerGenerated]
	public struct SnoGroup
	{
		public static implicit operator int(SnoGroup snoGroup)
		{
			return snoGroup.Value;
		}
		
		public static implicit operator SnoGroup(int value)
		{
			return new SnoGroup { Value = value };
		}
		
		public int Value;
		
		public override string ToString()
		{
			return ((Enigma.D3.Enums.SnoGroupId)Value).ToString().ToUpper() + "_SNO";
		}
	}
	
	[CompilerGenerated]
	public struct SnoNameHandle
	{
		public static implicit operator int(SnoNameHandle snoNameHandle)
		{
			return snoNameHandle.Value;
		}
		
		public static implicit operator SnoNameHandle(int value)
		{
			return new SnoNameHandle { Value = value };
		}
		
		public int Value;
		
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
	[CompilerGenerated]
	public struct Time
	{
		public static implicit operator float(Time time)
		{
			return time.Value;
		}
		
		public static implicit operator Time(float value)
		{
			return new Time { Value = value };
		}
		
		public float Value;
		
		public override string ToString()
		{
			return (Value / 60f).ToString("0.00 sec");
		}
	}
	
	[CompilerGenerated]
	public struct Translateable
	{
		public static implicit operator int(Translateable translateable)
		{
			return translateable.Value;
		}
		
		public static implicit operator Translateable(int value)
		{
			return new Translateable { Value = value };
		}
		
		public int Value;
		
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
	[CompilerGenerated]
	public struct Velocity
	{
		public static implicit operator float(Velocity velocity)
		{
			return velocity.Value;
		}
		
		public static implicit operator Velocity(float value)
		{
			return new Velocity { Value = value };
		}
		
		public float Value;
		
		public override string ToString()
		{
			return (Value * 60f).ToString("0.00") + " ft/s";
		}
	}
}
