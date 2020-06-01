using System;

using System.ComponentModel.DataAnnotations;


namespace Umbracofinal.Services
{
    public class AgeServices : ValidationAttribute, IAge
    {
        public int MinAge { get; }


        public AgeServices(int minAge)
        {
            MinAge = minAge;
            ErrorMessage = "{0} must be someone at least {1} years of age";

        }
        public  bool IsValid(int value)
        {
            /*  DateTime date;
              if ((value != null && DateTime.TryParse(value.ToString(), out date)))
              {
                  return date.AddYears(MinAge) < DateTime.Now;
              }

              return false;*/
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
