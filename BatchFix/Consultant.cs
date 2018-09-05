using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constants;

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
		private string fax;
		private string email;
		private string signerName;
		private string signerTitle;

		Consultant(string consultantName)
		{

			if (consultantName == "EF")
			{
				// Assign values based on constant strings for each company
				Name = EF_NAME;
				Address = EF_ADDRESS;
				City = EF_CITY;
				State = EF_STATE;
				ZipCode = EF_ZIP;
				Phone = EF_PHONE;
				Fax = EF_FAX;
				Email = EF_EMAIL;
				SignerName = EF_SIGNER;
				SignerTitle = EF_SIGNER_TITLE;
				
			} else if (consultantName == "NTC")
			{
				// Assign values based on constant strings for each company
				Name = NTC_NAME;
				Address = NTC_ADDRESS;
				City = NTC_CITY;
				State = NTC_STATE;
				ZipCode = NTC_ZIP;
				Phone = NTC_PHONE;
				Fax = NTC_FAX;
				Email = NTC_EMAIL;
				SignerName = NTC_SIGNER;
				SignerTitle = NTC_SIGNER_TITLE;
			}
			else
			{
				// todo error message for invalid consultant
				Console.WriteLine("Invalid consultant company name. Must be EF or NTC.");
			}
		}

		public string Name { get => name; set => name = value; }
		public string Address { get => address; set => address = value; }
		public string City { get => city; set => city = value; }
		public string State { get => state; set => state = value; }
		public string ZipCode { get => zipCode; set => zipCode = value; }
		public string Phone { get => phone; set => phone = value; }
		public string Fax { get => fax; set => fax = value; }
		public string Email { get => email; set => email = value; }
		public string SignerName { get => signerName; set => signerName = value; }
		public string SignerTitle { get => signerTitle; set => signerTitle = value; }
	}
}
