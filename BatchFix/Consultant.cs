using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	class Consultant
	{
		private string name;
		private string address;
		private string city;
		private string state;
		private string zipCode;
		private string phone;
		private string email;
		private string signerName;
		private string signerTitle;

		Consultant(string consultantName)
		{

			if (Name == "EF")
			{
				//todo assign other fields
			} else if (Name == "NTC")
			{

			}
			else
			{
				// todo error message for invalid consultant
			}
		}

		public string Name { get => name; set => name = value; }
		public string Address { get => address; set => address = value; }
		public string City { get => city; set => city = value; }
		public string State { get => state; set => state = value; }
		public string ZipCode { get => zipCode; set => zipCode = value; }
		public string Phone { get => phone; set => phone = value; }
		public string Email { get => email; set => email = value; }
		public string SignerName { get => signerName; set => signerName = value; }
		public string SignerTitle { get => signerTitle; set => signerTitle = value; }
	}
}
