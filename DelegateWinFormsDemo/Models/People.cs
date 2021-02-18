using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateWinFormsDemo.Models
{
    public class People
    {
        public static IList<Person> GetPeople()
        {
            var p = new List<Person>()
            {
                new Person() {FirstName = "Kenan", LastName = "Kurda", Age = 30 , StartDate = DateTime.Parse("17/10/2008")},
                new Person() {FirstName = "Saif", LastName = "Al Adilee", Age = 25 , StartDate = DateTime.Parse("13/12/2010")},
                new Person() {FirstName = "Jarno", LastName = "Maes", Age = 21 , StartDate = DateTime.Parse("06/10/2020")},
                new Person() {FirstName = "Yannick", LastName = "Betermans", Age = 26 , StartDate = DateTime.Parse("08/09/2016")},
                new Person() {FirstName = "Sadki", LastName = "Kadhija", Age = 25 , StartDate = DateTime.Parse("17/11/2015")},
                new Person() {FirstName = "Emre", LastName = "Elagoz", Age = 26 , StartDate = DateTime.Parse("28/10/2012")},
                new Person() {FirstName = "Timothy", LastName = "Hsu", Age = 24 , StartDate = DateTime.Parse("17/10/2020")},
                new Person() {FirstName = "Ruben", LastName = "Spillebeen", Age = 22 , StartDate = DateTime.Parse("16/09/2020")},
                new Person() {FirstName = "Muhammed", LastName = "Hebili", Age = 28 , StartDate = DateTime.Parse("17/05/2008")},
            };
            return p;
        }
    }
}
