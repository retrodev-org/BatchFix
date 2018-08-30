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
		
		// TODO: create getters and setters
		
		public Employer()
		{
			// TODO: create Employer constructor	
		}
		
		
		// Validators
		private CheckAddress()
		{
			// Invalid characters
			Regex nonAlphaNumeric = new Regex(@"^[a-zA-Z0-9_]+$");
			
			// Street1
			if(regex1.IsMatch(this.Street1))
			{
				string[] thisStreet1 = Regex.Split(this..Street1);
				this.Street1 = null;
				
				for(int i = 0; i < thisStreet1.Length; i++){
					this.Street1 += thisStreet1[i];
				}
				
				if (Street1.Length < 3)
				{
					// TODO throw exception for invalid street address
				}
			}
			
			// Street2
			if(regex1.IsMatch(this.Street2))
			{
				string[] thisStreet2 = Regex.Split(this.Street2);
				this.Street2 = null;
				
				for(int i = 0; i < thisStreet2.Length; i++){
					this.Street2 += thisStreet1[i];
				}
			}
			
			// City
			if(regex1.IsMatch(this.City))
			{
				string[] thisCity = Regex.Split(this.City);
				this.City = null;
				
				for(int i = 0; i < thisCity.Length; i++){
					this.City += thisCity[i];
				}
			}
		}
		
		private CheckPhone(){
			if (this.Phone = null || this.Phone.Length < 10)
			{
				// Auto populate default phone num for NTC, EF
				if (Consultant.Name = "NTC"){
					this.Phone = NTC_PHONE;
				} else {
					this.Phone = EF_PHONE; 
			}
		}
		
		private CheckFEIN(){
			this.FEIN = CheckLength(this.FEIN,9);
		}
		
		private CheckZip(){
			this.Zip = CheckLength(this.Zip,5);
		}
	}
}
