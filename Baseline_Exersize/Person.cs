using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Baseline_Exersize22
{
   public class Person
    {

        private String _first_name;
        private String _last_name;
        public Address Address { get; set; }
        public String City
        {
            get
            {
                return _first_name;
            }
            set
            {
                try
                {
                    if (!IsValidName(value))
                        throw new Exception("The valid first name");
                    value = _first_name;
                }
                catch (Exception e)
                {
                    Console.WriteLine("error" + e.Message);
                }
            }
        }


        public String Last_name
        {
            get
            {
                return _last_name;
            }
            set
            {
                try
                {
                    if (!IsValidName(value))
                        throw new Exception("The valid last name");
                    value = _last_name;
                }
                catch (Exception e)
                {
                    Console.WriteLine("error" + e.Message);
                }
            }
        }
        public static bool IsValidName(String str)
        {
            if (str.Length <= 1)
                return false;
            string pattern = @"^[\p{L} \-]+$";

            return Regex.IsMatch(str, pattern);
        }

        public Person()
        {
            Address = new Address();
        }

    }
}
