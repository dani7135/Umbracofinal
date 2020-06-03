using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using System.Diagnostics;



namespace Umbracofinal.Services
{
    public class ValidateSerialNumber : ISerialNumber
    {       

        DataAccess access = new DataAccess( );

        public bool ValidedSerialsNumber(int number)
        {
            List<int> valid =access.GetSerialsNumbers();
            foreach (var item in valid)
            {
                if (number == item)
                {
                    Debug.WriteLine("Det virker");

                    return true;
                }
            }
            Debug.WriteLine("Det virker ikke");

            return false;
        }
    }
}
