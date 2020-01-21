#define CONSTRUCTOR_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp5
{

	class Program
	{
		static void Main(string[] args)
		{
#if CONSTRUCTOR_CHECK
			Fraction a = new Fraction(1, 1, 2);
			Console.WriteLine("a = " + a);

			//Console.WriteLine(a);
			//a.ToImProper();
			//Console.WriteLine(a);
			//a.ToProper();
			//Console.WriteLine(a); 
			Fraction b = new Fraction(1, 2, 3);
			Console.WriteLine("b = " + b);


			//Console.WriteLine("a * b  " + (a * b));
			//Console.WriteLine("a = " + a);
			//Console.WriteLine("b = " + b);

			//Console.WriteLine("a / b  " + (a / b));
			//Console.WriteLine("a = " + a);
			//Console.WriteLine("b = " + b);

			//Console.WriteLine("a + b  " + (a + b));
			//Console.WriteLine("a = " + a);
			//Console.WriteLine("b = " + b);

			//Console.WriteLine("a - b  " + (a - b));
			//Console.WriteLine("a = " + a);
			//Console.WriteLine("b = " + b);

			Console.WriteLine(a+b);
			Console.WriteLine(a);
			Console.WriteLine(b);
			a += b;
			Console.WriteLine(++a);
#endif
			int n = 5;
			while (Convert.ToBoolean(n--)) Console.WriteLine("Hello");
		}
	}
}

