using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
	class Rectangle : Shape
	{
		float width;
		float height;
		public float Width
		{
			get => width;
			set => width = FilterSize(value);
		}
		public float Height
		{
			get => height;
			set => height = FilterSize(value);
		}
		public Rectangle(float width, float height, int startX, int startY, int lineWidth, Color color) :
			base(startX, startY, lineWidth, color)
		{
			this.Width = width;
			this.Height = height;
		}
		public override double GetArea() => Width * Height;
		public override double GetPerimeter() => (Width + Height) * 2;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, Width, Height);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Ширина прямоугольника:\t{Width}");
			Console.WriteLine($"Высота прямоугольника:\t{Height}");
			base.Info(e);
		}
	}
	class Square : Rectangle
	{
		public Square(float side, int startX, int startY, int lineWidth, Color color) : base(side, side, startX, startY, lineWidth, color) { }
	}
}
