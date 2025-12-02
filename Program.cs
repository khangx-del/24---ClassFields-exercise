using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___ClassFields_exercise
{
    internal class Program
    {
        class Person
        {
            private string firstName;
            private string lastName;
            private int age;
            private int birthYear;
            private string nationality;

            public Person(string name, string lastName, int age, int birthyear, string nationality)
            {
                this.firstName = name;
                this.lastName = lastName;
                this.age = age;
                this.birthYear = birthyear;
                this.nationality = nationality;
            }
            public void SetFirstName(string firstName)
            {
                this.firstName = !string.IsNullOrEmpty(firstName) ? firstName : "invalid first name";
            }

            public string GetFirstName()
            {
                return firstName;
            }

            public void SetLastName(string lastName)
            {
                this.lastName = !string.IsNullOrEmpty(lastName) ? lastName : "invalid last name";
            }

            public string GetLastName()
            {
                return lastName;
            }

            public void SetAge(int age)
            {
                this.age = age >= 0 && age < 150 ? age : -1;
            }

            public int GetAge()
            {
                return age;
            }

            public void SetBirthYear(int birthyear)
            {
                this.birthYear = birthyear >= 0 && birthyear < 2025 ? birthyear : -1;
            }

            public int GetBirthYear()
            {
                return birthYear;
            }
            public void SetNationality(string nationality)
            {
                this.nationality = !string.IsNullOrEmpty(nationality) ? nationality : "invalid nationality";
            }

            public string GetNationality()
            { 
                return nationality; 
            }

            public string ReturnDetails()
            {
                return $"First Name: {firstName}\nLast Name: {lastName}\nAge: {age}\nBirth Year: {birthYear}\nNationality: {nationality}";
            }
        }
                     
        static void Main(string[] args)
        {
            Person person = new Person("Alex", "Carter", 21, 2004, "Canadian");
            Console.WriteLine(person.ReturnDetails());
             
            Console.WriteLine();

            person.SetFirstName("Tim");
            person.SetLastName("Rivera");
            person.SetAge(30);
            person.SetBirthYear(1995);
            person.SetNationality("American");
            Console.WriteLine(person.ReturnDetails());
        }
    }
}
