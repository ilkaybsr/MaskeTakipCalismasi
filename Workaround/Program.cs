using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "BÜŞRA";
            person1.LastName = "AYDIN";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 123;


            Person person2 = new Person();
            person2.FirstName = "BATUHAN";
            person2.LastName = "ÖZYÖN";
            person2.DateOfBirthYear = 1996;
            person2.NationalIdentity = 12345;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();

        }
    }
}

