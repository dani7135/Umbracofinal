using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;


namespace Umbracofinal.Services
{
    public class ValidateSerialNumber : ISerialNumber
    {
        private DataAccess _access;
        public ValidateSerialNumber(DataAccess data)
        {
            _access = data;
        }
        public bool ValidedSerialNumber(int number)
        {
            List<int> listOfNumber = _access.GetSerialsNumbers();
            foreach (var item in listOfNumber)
            {
                if (number == item)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidedSerialsNumber(int number)
        {
            throw new NotImplementedException();
        }

        /*DataAccess access = new DataAccess();

        public bool ValidedSerialsNumber(int number)
        {
            List<int> listOfNumber =access.GetSerialsNumbers();
            foreach (var item in listOfNumber)
            {
                if (number == item)
                {
                    return true;
                }

            }
            return false;
        }
      private readonly UmbracoContext _dataAccess;
      private readonly DataAccess da;
      public ValidateSerialNumber(UmbracoContext dataAccess)
      {
          _dataAccess = dataAccess;
      }
     /* public bool ValidedSerialsNumber(int number)
      {
         /* List<int> listOfNumber = _dataAccess.GetSerialsNumbers();
          foreach (var item in listOfNumber)
          {
              if (number == item)
              {
                  return true;
              }

          }
          return false;
      }
  }*/
    }
}
