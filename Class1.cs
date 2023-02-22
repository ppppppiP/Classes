using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Schools
	{
		public string Name { get; set; }
		public string DirectorName { get; set; }
		public long PhoneNumber { get; set; }
		public Schools(){

}

		public Schools(string name, string directorName, long phoneNumber)
		{
			Name = name;
			DirectorName = directorName;
			PhoneNumber = phoneNumber;
		}
		public override string ToString()
		{
			return "Название образовательной организации \" " + Name + "\". Имя dиректора: " + DirectorName + " Номер телфона директора";
		}
	}
}
