using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateWinFormsDemo.Models
{
    public class Formatters
    {
        public static string Default(Person input)
        {
            return input.ToString();
        }

        public static string LastNameToUpper(Person input)
        {
            return input.LastName.ToUpper();
        }

        public static string FirstNameToLower(Person input)
        {
            return input.FirstName.ToLower() +  " Hello and Welcome";
        }

        public static string FullNameToUpper(Person input)
        {
            return $"{input.FirstName} {input.LastName} Age is {input.Age}";
        }
    }
}
