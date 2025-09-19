using static System.Runtime.InteropServices.JavaScript.JSType;

///
/// An API or Application Programming Interface is any protocol specifying how software components should
/// interact with each other.
/// 
/// It enables the communication between different systems.
/// 
/// Most countries have some central weather administration.
/// An institution like this usually wants to publish the data they gather so other institutions, companies
/// or individuals can access it.
/// 
/// This institution will expose a web endpoint at which this data will be available.
/// This means there will be an URL address identifying this data.
/// 
/// And if we use this URL, then as a response, we will get a JSON with this data. In a simple case
/// we could just paste such an URL in the browser and we would see the JSON there.
/// Of course, some APIs also need to receive data.
/// 
/// In this case, the users can send a JSON to the API, which then processes it accordingly.
/// 
/// Please notice that JSON is not the only format of the data that can be used, but it is the most common
/// one for web APIs.
/// 
/// E.g. 
/// If we make the below api call:
/// https://datausa.io/api/data?drilldowns=Nation&measures=Population
/// then I will get JSON:
/// 
/*
 {
  "data":[
    {
      "ID Nation": "01000US",
      "Nation": "United States",
      "ID Year": 2016,
      "Year": "2016",
      "Population": 323127515,
      "Slug Nation": "united-states"
    },
    {
      "ID Nation": "01000US",
      "Nation": "United States",
      "ID Year": 2015,
      "Year": "2015",
      "Population": 321418821,
      "Slug Nation": "united-states"
    },
    {
      "ID Nation": "01000US",
      "Nation": "United States",
      "ID Year": 2014,
      "Year": "2014",
      "Population": 318857056,
      "Slug Nation": "united-states"
    },
    {
      "ID Nation": "01000US",
      "Nation": "United States",
      "ID Year": 2013,
      "Year": "2013",
      "Population": 316128839,
      "Slug Nation": "united-states"
    }
  ],
  "source": [
    {
      "measures": ["Population"],
      "annotations": {
        "source_name": "Census Bureau",
        "source_description": "Census Bureau conducts surveys of the United States Population, including the American Community Survey",
        "dataset_name": "ACS 1-year Estimate",
        "dataset_link": "http: //www.census.gov/programs-surveys/acs/",
        "table_id": "B01003",
        "topic": "Diversity"
      },
      "name": "acs_yg_total_population_1",
      "substitutions": [ ]
    }
  ]
}
*/
/// 
/// APIs can be either open or closed.
/// Open APIs, also known as external or public APIs are available with little restriction and are intended
/// for external users.
/// 
/// Closed or internal APIs are intended for internal use within an organization and are typically protected
/// by authentication and access controls.
/// 
/// 
///