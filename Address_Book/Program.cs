using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("---------**** Welcome to Address Book System ****---------");
            Booksystem Ads = new Booksystem();
            Ads.CreateContacts();
            Ads.AddContact();
        }
    }
}
