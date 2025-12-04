//#define PROPERTIES
//#define CONSTRUCTORS
//#define INCREMENT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
#if PROPERTIES
			Point A = new Point();
			//A.SetX(2);
			//A.SetY(3);
			A.X = 2;    //Свойства позволяют использовать инкапсуляцию как обычные переменные в классе.
			A.Y = 3;
			//Console.WriteLine($"{A.GetX()}\t{A.GetY()}");
			//Assignment - Присваивание
			//Unassigned - неприсвоенный
			A.Print();

			Point B = new Point();
			B.X = 7;
			B.Y = 8;
			B.Print(); 
#endif

#if CONSTRUCTORS
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);

			Console.WriteLine($"Растояние от точки 'A' до точки 'B':{A.Distance(B)}");

			Point C = new Point(A);     //CopyConstrcutor

			int a = 2;
			int b = 3;
			//a + b;

			Point D = A + B;
			D.Print();

			A += B;
			A.Print(); 
#endif

#if INCREMENT
			Point i = new Point(2, 3);
			Point j = null;
			for (; i.X < 10; j = ++i)
			{
				i.Print();
			}
			Console.WriteLine("\n---------------------------------\n");
			i.Print();
			j.X = 100;
			Console.WriteLine("\n---------------------------------\n");
			i.Print(); 
#endif

			Point A = new Point(2, 3);
			Point B = new Point(7, 8);

			Console.WriteLine(A > B);

		}
	}
}
