using CountryGwp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galytix.WebApi.Model
{
    class gwpModel
    {
        private ICountryGwp _instance = null;

        public gwpModel(ICountryGwp obj)
        {
            _instance = obj;
        }

        public List<CountryGwpResult> GetReponse(string country, List<string> listOfBusiness)
        {            
            return _instance.GetAverageLineOfBusinnes(country, listOfBusiness);            
        }
    }

    public class GwpInfo
    {
        public string country { get; set; }
        public List<string> listOfBusiness { get; set; }
    }
}
