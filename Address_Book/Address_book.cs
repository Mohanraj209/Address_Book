using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
	internal class Booksystem
	{

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public long PhoneNumbers { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public void CreateContacts()
        {
            Booksystem Ads = new Booksystem();
            Console.Write("\n Enter FirstName: ");
            Ads.FirstName = Console.ReadLine();
            Console.Write("\n Enter LastName: ");
            Ads.LastName = Console.ReadLine();

            Console.Write("\n Enter PhoneNumber: ");
            Ads.PhoneNumber = (int)Convert.ToInt64(Console.ReadLine());
           

            Console.Write("\n Enter Email ID: ");
            Ads.EmailId = Console.ReadLine();
            Console.Write("\n Enter Address: ");
            Ads.Address = Console.ReadLine();
            Console.Write("\n Enter City: ");
            Ads.City = Console.ReadLine();
            Console.Write("\n Enter State: ");
            Ads.State = Console.ReadLine();
            Console.Write("\n Enter ZipCode: ");
            Ads.ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Contact Created:- \n\n First_Name: " + Ads.FirstName + "\n Last_Name: " + Ads.LastName +
                "\n Phone_Num: " + Ads.PhoneNumber + "\n Mail: " + Ads.EmailId + "\n Address: " + Ads.Address + "\n City: "
                + Ads.City + "\n State: " + Ads.State + "\n Zipcode: " + Ads.ZipCode);
        }
    }

}