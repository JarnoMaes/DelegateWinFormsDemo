using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateWinFormsDemo.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $" Full Name: {FirstName} {LastName} Age: {Age}";
        }

        public string ToString(PersonFormat format)
        {
            if (format != null)
            {
                return format(this);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
