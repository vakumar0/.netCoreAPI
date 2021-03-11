# .netCoreAPI
A .net core Web API to fetch average gross written premium (GWP) using .csv file as a data source.

## Requirements

 - Visual studio 2019
 - Postman
 
### Tech Stack And Libaries
  -  Visual Studio 2019
  -  csvParser  

### Projects Description
  - GwpController (Controller)
  - GwpModel (Model)
  - CountryGwp ( C# library which contains the business logic )
  
### API description and call 
  - http://localhost:9091/api/gwp/avg is used for fetching average gross written premium (GWP) data from the year 2008 to 2015
  - This API accepts list of GwpInfo class i.e.  {
	     "country": "ae",
	     "listOfBusiness":["transport","property"]
     }
    - type of country is string
    - type of listOfbusiness is List<string>.
  - API Response  [
        {
            "lineOfBusiness": "transport",
            "value": 249495209.6625
        },
        {
            "lineOfBusiness": "property",
            "value": 524148489.3
        }
     ]
     
