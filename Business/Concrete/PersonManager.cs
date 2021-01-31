﻿using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person) 
        {


        }

        public List<Person> GetList() 
        {
            return null;
        }

        public bool CheckPerson (Person person) 
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return  client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}