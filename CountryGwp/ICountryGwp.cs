using System;
using System.Collections.Generic;
using System.Text;

namespace CountryGwp
{
    public interface ICountryGwp
    {
        List<CountryGwpResult> GetAverageLineOfBusinnes(string country, List<string> listOfBusiness);
    }
}
