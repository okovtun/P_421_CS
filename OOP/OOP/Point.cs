using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Point
	{
		double x;
		double y;
		/*
		private:
		public:
		protected:
		internal:
		protected internal:
		 */
		//Get/Set-методы
		public double GetX()
		{
			return x;
		}
		public double GetY()
		{
			return y;
		}
		public void SetX(double x)
		{
			this.x = x;
		}
		public void SetY(double y)
		{
			this.y = y;
		}
		//Proprties (Свойства) - это синтаксическая конструкция, 
		//которая объединяет Get и Set метод для какой-то переменной в классе:
		//Свойства обычно называют так же как и переменную, но с бльшой буквы
		//(переменную называют с маленькой).
		public double X
		{
			get
			{
				return x;
			}
			set
			{
				x = value;
			}
		}
		public double Y
		{
			get
			{
				return y;
			}
			set
			{
				y = value;
			}
		}

		//				Constructors:
		public Point()
		{
			Console.WriteLine($"DefaultConstructor:\t{this.GetHashCode()}");
		}
		public Point(double x=0, double y=0)
		{
			this.X = x;
			this.Y = y;
			Console.WriteLine($"Constructor:\t\t{this.GetHashCode()}");
		}
		public Point(Point other)
		{
			this.X = other.X;
			this.Y = other.Y;
			Console.WriteLine($"CopyConstructor:\t{this.GetHashCode()}");
		}
		~Point()
		{
			//Destructor - это метод, который уничтожает объект по завершении его времени жизни.
			Console.WriteLine($"Destructor:\t\t{this.GetHashCode()}");
		}

		//				Operators:
		public static Point operator+(Point left, Point right)
		{
			//Point result = new Point
			//	(
			//	left.X + right.X,
			//	left.Y + right.Y
			//	);
			//return result;

			return new Point
				(
					left.X + right.X,
					left.Y + right.Y
				);
		}
		public static Point operator ++(Point obj)
		{
			obj.X++;
			obj.Y++;
			return new Point(obj);
		}

		public static bool operator ==(Point left, Point right)
		{
			return left.X == right.X && left.Y == right.Y;
		}
		public static bool operator !=(Point left, Point right)
		{
			return left.X != right.X || left.Y != right.Y;
		}
		public static bool operator >(Point left, Point right)
		{
			return left.X + left.Y > right.X + right.Y;
		}
		public static bool operator <(Point left, Point right)
		{
			return left.X + left.Y < right.X + right.Y;
		}

		//				Methods:
		public double Distance(Point other)
		{
			double x_distance = this.X - other.X;
			double y_distance = this.Y - other.Y;
			double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distance;
		}
		public void Print()
		{
			Console.WriteLine($"X = {x}\tY = {y}");
		}
	}
}
