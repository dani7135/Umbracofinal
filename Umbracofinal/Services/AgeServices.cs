using System;

using System.ComponentModel.DataAnnotations;


namespace Umbracofinal.Services
{
    public class AgeServices : ValidationAttribute, IAge
    {
        public int MinAge { get; }


  
        public  bool IsValid(int value)
        {
          
             if (value < 18)
            {
                return false;

            }
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, MinAge);
        }
    }
}
