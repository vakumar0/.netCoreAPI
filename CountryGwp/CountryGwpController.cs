using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CountryGwp
{
    class CountryGwpController
    {
        public List<CountryGwpInfo> GetCsvData()
        {
            List<CountryGwpInfo> result;                      
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true, HeaderValidated = null, MissingFieldFound = null, IgnoreBlankLines = false };

                using (var reader = new StreamReader("gwpByCountry.csv"))
                using (var csv = new CsvReader(reader, config))
                {
                    var records = csv.GetRecords<CountryGwpInfo>();
                    result = csv.GetRecords<CountryGwpInfo>().ToList();
                }
            } 
            catch (Exception ex)
            {
                throw;
            }            

            return result;

        }

    }
}
