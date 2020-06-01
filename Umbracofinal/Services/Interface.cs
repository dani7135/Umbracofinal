using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using ClassLibrary;


namespace Umbracofinal.Services
{
    interface Interface
    {
    }
    public interface ISerialNumber
    {
        bool ValidedSerialsNumber(int number);
        List<int> GetSerialsNumbers();
    }
    public interface IAge
    {
        bool IsValid(int value);
        string FormatErrorMessage(string name);
    }
}
