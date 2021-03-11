using System;
using System.Collections.Generic;

namespace CountryGwp
{
    public class CountryGwpService : ICountryGwp
    {
        public List<CountryGwpResult> GetAverageLineOfBusinnes(string country, List<string> listOfBusiness)
        {
            List<CountryGwpResult> output = new List<CountryGwpResult>();
            CountryGwpController controller = new CountryGwpController();

            try
            {
                List<CountryGwpInfo> cInfo = controller.GetCsvData();

                foreach (string business in listOfBusiness)
                {
                    foreach (CountryGwpInfo gwp in cInfo)
                    {
                        if (gwp.country.Equals(country) && gwp.lineOfBusiness.Equals(business))
                        {
                            double? y2008 = gwp.Y2008 == null ? 0 : gwp.Y2008;
                            double? y2009 = gwp.Y2009 == null ? 0 : gwp.Y2009;
                            double? y2010 = gwp.Y2010 == null ? 0 : gwp.Y2010;
                            double? y2011 = gwp.Y2011 == null ? 0 : gwp.Y2011;
                            double? y2012 = gwp.Y2012 == null ? 0 : gwp.Y2012;
                            double? y2013 = gwp.Y2013 == null ? 0 : gwp.Y2013;
                            double? y2014 = gwp.Y2014 == null ? 0 : gwp.Y2014;
                            double? y2015 = gwp.Y2015 == null ? 0 : gwp.Y2015;

                            double? average = (y2008 + y2009 + y2010 + y2011 + y2012 + y2013 + y2014 + y2015) / 8;

                            output.Add(new CountryGwpResult { lineOfBusiness = business, value = average });
                        }
                    }
                }
            }
            catch (Exception)
            {
                /*Log Error here*/
                throw;
            }

            return output;
        }
    }
}
