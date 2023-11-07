using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Baseline_Exersize22
{

    public class Address
    {

        private String _city;
        private String _street;
        private int _apt_number;
        public String City
        {
            get
            {
                return _city;
            }
           set
            {
                try
                {
                    if (!IsValidStr(value))
                        throw new Exception("The valid string");
                    value = _city;
                }
                catch(Exception e)
                {
                    Console.WriteLine("error" + e.Message);
                }
            }
        }


        public String Street
        {
            get
            {
                return _street;
            }
            set
            {
                try
                {
                    if (!IsValidStr(value))
                        throw new Exception("The valid street");
                    value = _street;
                }
                catch (Exception e)
                {
                    Console.WriteLine("error" + e.Message);
                }
            }
        }

        public int Apt_number
        {
            get
            {
                return _apt_number;
            }
            set
            {
                try
                {
                    if (value <=0)
                        throw new Exception("The valid street");
                    value = _apt_number;
                }
                catch (Exception e)
                {
                    Console.WriteLine("error" + e.Message);
                }
            }
        }
        public static bool IsValidStr(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            string pattern = @"^[\p{L} \-0-9]+$";

            return Regex.IsMatch(str, pattern);
        }
    }
}
