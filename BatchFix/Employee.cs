using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConstants;

namespace BatchFix
{
	class Employee
	{
		String firstName;
		String middleName;
		String lastName;
		String street;
		String street2;
		String city;
		String county;
		String state;
		String zip;
		String phone;
		String social;
		String email;

		List<String> requestID; // List of application request IDs associated with employee, in case of rehire or more than one employer

		public string getName()
		{
			return FirstName + " " + MiddleName[0] + " " + LastName;
		}

		public string FirstName { get => firstName; set => firstName = value; }
		public string MiddleName { get => middleName; set => middleName = value; }
		public string LastName { get => lastName; set => lastName = value; }
		public string Street { get => street; set => street = value; }
		public string Street2 { get => street2; set => street2 = value; }
		public string City { get => city; set => city = value; }
		public string County { get => county; set => county = value; }
		public string State { get => state; set => state = value; }
		public string Zip { get => zip; set => zip = value; }
		public string Phone { get => phone; set => phone = value; }
		public string Social { get => social; set => social = value; }
		public string Email { get => email; set => email = value; }
	}
}
