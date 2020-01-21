using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Fraction
	{
		int integer;
		int numerator;
		int denominator;

		public int Integer
		{
			get
			{
				return integer;
			}
			set
			{
				integer = value;
			}
		}
		public int Numerator
		{
			get => numerator;
			set => numerator = value;
		}
		public int Denominator
		{
			get => denominator;
			// set => denominator = ((value != 0)? denominator = value: denominator  = 1);
			set => denominator = value == 0 ? 1 : value;
		}

		public override string ToString()
		{
			string fraction = "0";
			if (numerator != 0)
			{
				fraction = $"{numerator}/{denominator}";
			}

			if (integer != 0)
			{
				fraction = fraction.Insert(0, Integer.ToString() + "(");
				fraction += ")";
				//fraction = $"{integer}({numerator}/{denominator})";
			}
			return fraction;
		}
		//CONSTRUCTORS
		public Fraction()
		{
			Integer = 0;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		public Fraction(int integer)
		{
			Integer = integer;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		public Fraction(int numerator, int denominator)
		{
			Integer = 0;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		public Fraction(int integer, int numerator, int denominator)
		{
			Integer = integer;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine("Constructor:\t" + this.GetHashCode());
		}
		public Fraction ToProper()
		{
			integer += numerator / denominator;
			numerator %= denominator;
			return this;
		}
		public Fraction ToImProper()
		{
			numerator += integer * denominator;
			integer = 0;
			return this;
		}

		~Fraction()
		{
			Console.WriteLine("Destructor:\t" + this.GetHashCode());
		}
		public static Fraction operator *(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator).ToProper();
		}
		public static Fraction operator /(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return new Fraction(left.Numerator * right.Denominator, left.Denominator * right.Numerator).ToProper();
		}
		public static Fraction operator +(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return new Fraction((left.Numerator * right.Denominator + right.Numerator * left.Denominator), (left.Denominator * right.Denominator)).ToProper();
		}
		public static Fraction operator -(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return new Fraction((left.Numerator * right.Denominator - right.Numerator * left.Denominator), (left.Denominator * right.Denominator)).ToProper();
		}
		
		public static Fraction operator ++(Fraction operand)
		{
			operand.ToProper();
			return new Fraction(operand.Integer += 1);
		}
		public static Fraction operator --(Fraction operand)
		{
			operand.ToProper();
			return new Fraction(operand.Integer -= 1);
		}
		public static bool operator <(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return (left.Numerator * right.Denominator < right.Numerator * left.Denominator);
		}
		public static bool operator <=(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return (left.Numerator * right.Denominator <= right.Numerator * left.Denominator);
		}
		public static bool operator >(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return (left.Numerator * right.Denominator > right.Numerator * left.Denominator);
		}
		public static bool operator >=(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return (left.Numerator * right.Denominator >= right.Numerator * left.Denominator);
		}
		public static bool operator ==(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return (left.Numerator * right.Denominator == right.Numerator * left.Denominator);
		}
		public static bool operator !=(Fraction left, Fraction right)
		{
			left.ToImProper();
			right.ToImProper();
			return !(left.Numerator * right.Denominator == right.Numerator * left.Denominator);
		}
		
		//Сокращенные операции присваивания не могут перегружаться; однако вы получаете их автоматически, перегружая соответствующую бинарную операцию
		//    public static Fraction operator /=(Fraction left, Fraction right)
		//        {
		//            left = left / right;
		//            return left;
		//        }
		//        public static Fraction operator +=(Fraction left, Fraction right)
		//        {
		//            left = left + right;
		//            return left;
		//        }
		//        public static Fraction operator-=(Fraction left, Fraction right)
		//        {
		//            left = left - right;
		//            return left;
		//        }
	}
}

