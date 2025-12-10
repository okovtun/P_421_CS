using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class AcademyMember:Human
	{
		public string Speciality { get; set; }
		public AcademyMember
			(
			string lastName, string firstName, int age,
			string speciality
			):base(lastName, firstName, age)
		{
			//Конеструктор дочернего класса кроме своих собственных полей
			//так же в обязательном порядке должен принимать поля всех своих родителей
			this.Speciality = speciality;
			Console.WriteLine($"AMConstructor:\t{GetHashCode()}");
		}
		~AcademyMember()
		{
			Console.WriteLine($"AMDestructor:\t{GetHashCode()}");
		}
		public void Info()
		{
			base.Info();	//Ключевое слово 'base' охначает непосредственного родителя.
			Console.WriteLine(Speciality);
		}
	}
}
