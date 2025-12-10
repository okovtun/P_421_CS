using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Program
	{
		const string delimiter = "\n------------------------------------\n";
		static void Main(string[] args)
		{
			Human human = new Human("Blackmore", "Ritchie", 32);
			human.Info();
			Console.WriteLine(delimiter);

			AcademyMember am = new AcademyMember("Dirkscheider", "Udo", 55, "Vocals");
			am.Info();
			Console.WriteLine(delimiter);

			Student student = new Student("Львов", "Константин", 16, "РПО", "P_421", 98, 100);
			student.Info();

			Teacher teacher = new Teacher("Henriksson", "Martin", 35, "Guitars", 15);
			teacher.Info();
		}
	}
}
