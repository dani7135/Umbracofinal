using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClassLibrary
{
    public class DataAccess 
    {
        readonly string textFile = @"SerialNumber.txt";
        private readonly UmbracoContext _umbracoContext;

        public DataAccess(UmbracoContext umbracoContext){
            _umbracoContext = umbracoContext;
        }
   
        public List<int> GetSerialsNumbers()
        {
            List<int> validSerialsNumbers = new List<int>();
            if (File.Exists(textFile))
            {
                using (StreamReader file = new StreamReader(textFile))
                {
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        validSerialsNumbers.Add(Convert.ToInt32(ln));
                    }
                    file.Close();
                }
            }
            return validSerialsNumbers;
        }       
        public List<Submisssion> GetSubmisssions()
        {
            return _umbracoContext.Submissions.ToList();
        }
    }
}