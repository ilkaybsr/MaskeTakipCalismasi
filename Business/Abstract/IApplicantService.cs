using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IApplicantService
    {
      void ApplyForMask(Person person);
       

      List<Person> GetList();
        

      bool CheckPerson(Person person);
        
    }
}
