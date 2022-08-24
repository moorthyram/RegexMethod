using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram_Day19
{
     class RegexClass
    {

        public static void RegexPattern()
        {
            String FirstName, lastName, email, phoneNumber;

            Regex nameregex = new Regex("^([A-Z]{1}[a-z]{2}([a-z]+)?)$");
            Regex emailregex = new Regex("^([0-9a-zA-Z])+([.+-][0-9a-zA-Z]+)?@([0-9a-zA-Z])+([.][a-zA-Z]{2,4})([.][a-zA-Z]{2})?$");
            Regex mobileregex = new Regex("^(0|91)?[6-9][0-9]{9}$");

            Console.WriteLine("Enter the First Name");
            var name = Console.ReadLine();
            Match matchfirstname = nameregex.Match(name);
            if (matchfirstname.Success)
            {
                FirstName = name;
                Console.WriteLine("Its valid name");
            }

            else
            {
                Console.WriteLine("Its Invalid name, Enter first letter capital and enter small letters");
            }


            Console.WriteLine("Enter the Last Name");
            var lName = Console.ReadLine();

            Match matchlname = nameregex.Match(lName);
            if (matchlname.Success)
            {
                lastName = lName;
                Console.WriteLine("Its valid name");
            }

            else
            {
                Console.WriteLine("It is Invalid name, Enter first letter Capital letter");
            }

            Console.WriteLine("Enter the EmailId");
            var mail = Console.ReadLine();

            Match matchemail = emailregex.Match(mail);
            if (matchemail.Success)
            {
                email = mail;
                Console.WriteLine("It is valid Mail");
            }
            else
            {
                Console.WriteLine("It is Invalid");
            }

            Console.WriteLine("Enter the Mobile Number");
            var number = Console.ReadLine();

            Match matchmobile = mobileregex.Match(number);
            if (matchmobile.Success)
            {
                phoneNumber = number;
                Console.WriteLine("It is valid Mobile Number");
            }
            else
            {
                Console.WriteLine("It is Invalid");
            }

        }
    }
}