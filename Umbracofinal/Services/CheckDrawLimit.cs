using System;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using System.Collections.Generic;

namespace Umbracofinal.Services
{

    public class CheckDrawLimit
    {

        private readonly UmbracoContext umbraco;
        public CheckDrawLimit(UmbracoContext context)
        {
            umbraco = context;
        }
      /*  DataAccess dataAccess = new DataAccess();

        public bool DrawWinner()
        {
            var number = new DataAccess();
            List<int> listOfNumber = GetSubmisssions();
            for (int i = 0; i < 2; i++)
            {
                return true;

            }
            return false;
           
        }*/

    }
}
