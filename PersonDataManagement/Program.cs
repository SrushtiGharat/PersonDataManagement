using System;
using System.Collections.Generic;
using System.Linq;
namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            AddRecords(personList);
            RetrievingTopTwoRecordsForAgeLessThanSixty(personList);
            RetrieveDataForTeenagePerson(personList);
            AverageAgeInList(personList);
            CheckName("Sue", personList);
            SkipRecordForAgeLessThanSixty(personList);
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
           
        }
        public static void RetrievingTopTwoRecordsForAgeLessThanSixty(List<Person> personList)
        {
            foreach (Person p in personList.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + p.Name + " Age :" + p.Age);
            }
        }
        public static void RetrieveDataForTeenagePerson(List<Person> personList)
        {
            foreach (Person p in personList.FindAll(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Name :"+p.Name);
            }
        }
        public static void AverageAgeInList(List<Person> personList)
        {
             double averageAge = personList.Average(e => e.Age);
             Console.WriteLine("Average age :"+averageAge);
            
        }
        public static void CheckName(string name,List<Person> personList)
        {
            if(personList.Any(e => e.Name.Equals(name)))
            {
                Console.WriteLine("Name is present in the list");
            }
            else
            {
                Console.WriteLine("Name is not present in the list");
            }
        }
        public static void SkipRecordForAgeLessThanSixty(List<Person> personList)
        {
            
            foreach(Person p in personList.OrderBy(e => e.Age).SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name :" + p.Name + " Age :" + p.Age);
            }
        }
    }
}
