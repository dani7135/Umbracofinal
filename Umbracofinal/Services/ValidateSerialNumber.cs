﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;

namespace Umbracofinal.Services
{
    public class ValidateSerialNumber : ISerialNumber
    {

        /*  DataAccess access = new DataAccess();

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
          }*/
        private readonly DataAccess _dataAccess;
        public ValidateSerialNumber(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public bool ValidedSerialsNumber(int number)
        {
            List<int> listOfNumber = _dataAccess.GetSerialsNumbers();
            foreach (var item in listOfNumber)
            {
                if (number == item)
                {
                    return true;
                }

            }
            return false;
        }
    }
}