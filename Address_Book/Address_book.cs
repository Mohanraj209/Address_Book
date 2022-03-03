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

        List<Booksystem> New_contacts = new List<Booksystem>();
        public void AddContact()
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

            New_contacts.Add(Ads);
        }


        public void EditContact(string FirstName)
        {
            Booksystem contacts = new Booksystem();
            foreach (var item in New_contacts)
            {
                if (item.FirstName == FirstName)
                {
                    contacts = item;
                    //return;
                    break;
                }
            }

            Console.WriteLine("\n Edit Contact");
            Console.WriteLine("1.LastName \n2.PhoneNumber \n3.EmailID \n4.Address \n5.City \n6.State \n7.ZipCode ");
            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        contacts.LastName = Console.ReadLine();
                        break;

                    case 2:
                        contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        contacts.EmailId = Console.ReadLine();
                        break;

                    case 4:
                        contacts.Address = Console.ReadLine();
                        break;

                    case 5:
                        contacts.City = Console.ReadLine();
                        break;

                    case 6:
                        contacts.State = Console.ReadLine();
                        break;

                    case 7:
                        contacts.ZipCode = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        flag = false;
                        break;

                }
                display(contacts);
            }



        }

        public static void display(Booksystem contacts)
        {
            Console.WriteLine("Create Contact:- \n" + contacts.FirstName + "\n" + contacts.LastName +
                "\n" + contacts.PhoneNumber + "\n" + contacts.EmailId + "\n" + contacts.Address + "\n"
                + contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode + "\n");
        }
    }
}

    