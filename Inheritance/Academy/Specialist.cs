using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Specialist:Graduate
	{
		public int Grade { get; set; }
		public Specialist
			(
			string lastName, string firstName, int age,
			string speciality,
			string group, double rating, double attendance,
			string subject,
			int grade
			) : base(lastName, firstName, age, speciality, group, rating, attendance, subject)
		{
			Grade = grade;
		}
		~Specialist()
		{

		}
		public override string ToString()
		{
			return base.ToString() + $" {Grade}";
		}
		public override string ToFileString()
		{
			return base.ToFileString() + $",{Grade}";
		}
	}
}
