using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
	class Circle:Shape
	{
		float radius;
		public float Raduis
		{
			get => radius;
			set => radius = FilterSize(value);
		}
		public Circle(float radius, int startX, int startY, int lineWidth, System.Drawing.Color color) :
			base(startX, startY, lineWidth, color)
		{
			this.Raduis = radius;
		}
		public override double GetArea() => Math.PI * Math.Pow(Raduis, 2);
		public override double GetPerimeter() => 2 * Math.PI * Raduis;
		public override void Draw(PaintEventArgs e) =>
			e.Graphics.DrawEllipse(new System.Drawing.Pen(Color, LineWidth), StartX, StartY, 2*Raduis, 2*Raduis);
	}
}
