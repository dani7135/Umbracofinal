using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;


namespace Umbracofinal.Services
{
    /*interface Interface
    {
    }*/
    public interface ISerialNumber
    {
        bool ValidedSerialsNumber(int number);
    }
    public interface IAge
    {
        bool IsValid(int value);
        string FormatErrorMessage(string name);
    }
}
