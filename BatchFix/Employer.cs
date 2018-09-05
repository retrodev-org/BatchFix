using System;
using MyConstants;

namespace BatchFix
{
	/// <summary>
	/// Class:	Employer
	/// Use:	Read and store employer information. (EIN, Address, Phone, etc.)
	/// </summary>
	public class Employer
	{
		private string fein;
		private string name;
		private string street1;
		private string street2;
		private string city;
		private string state;
		private string zipCode;
		private string phone;
		
		// TODO: create getters and setters (encapsulate, use field?)
		
		public Employer()
		{
			// TODO: create Employer constructor	
		}
		
		
		// Validators
		private bool CheckAddress()
		{
			// Invalid characters
			Regex nonAlphaNumeric = new Regex(@"^[a-zA-Z0-9_]+$");
			// TODO re-examine RegEx as means of validating CheckAddress() characters
			
			// Default state is true, updated if either address 1 or 2 fails validation
			bool isReady = true;
			
			// Street1
			if(regex1.IsMatch(Street1))
			{
				string[] myStreet1 = Regex.Split(Street1);
				
				Street1 = null;
				
				for(int i = 0; i < myStreet1.Length; i++){
					Street1 += myStreet1[i];
				}
				
				// Fail street 1 validation if less than 3 characters or consists only of numbers
				if (Street1.Length < 3 || !Street1.Contains("[a-zA-Z]"))
				{
					Console.WriteLine("Fail on Employer Street Address 1 validation.");
					isReady = false;
				}
			}
			
			// Street2
			if(regex1.IsMatch(Street2))
			{
				string[] myStreet2 = Regex.Split(Street2);
				Street2 = null;
				
				for(int i = 0; i < myStreet2.Length; i++){
					Street2 += myStreet2[i];
				}
				
				// Fail street 2 validation if less than 3 characters or consists only of numbers
				if (Street2.Length < 3 || !Street2.Contains("[a-zA-Z]"))
				{
					Console.WriteLine("Fail on Employer Street Address 2 validation.");
					isReady = false;
				}
			}
			
			// City
			if(regex1.IsMatch(City))
			{
				string[] myCity = Regex.Split(City);
				City = null;
				
				for(int i = 0; i < myCity.Length; i++){
					City += myCity[i];
				}
				
				// Fail city validation if consists only of numbers
				if (!City.Contains("[a-zA-Z]"))
				{
					Console.WriteLine("Fail on Employer City validation.");
					isReady = false;
				}
				
				return isReady;
			}
		}
		
		// Will substitute default phone number is given phone is invalid
		private void CheckPhone()
		{	
			// If phone is not present or invalid (less than 10 chars), substitute consultant phone number 
			if (this.Phone = null || this.Phone.Length < 10)
			{
				// Auto populate default phone num for NTC, EF
				if (Consultant.Name = "NTC"){
					this.Phone = NTC_PHONE;
				} else {
					this.Phone = EF_PHONE;
				}
			}
		}
		
		// Will pad beginning of FEIN with zeros until it reaches 9 digits
		private void CheckFEIN()
		{
			FEIN = CheckLength(FEIN,9);
		}
		
		// Will pad beginning of Zip with zeros until it reaches 5 digits
		private void CheckZip()
		{
			Zip = CheckLength(Zip,5);
		}
	}
}
