﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using IndianCensusAnalyser.POCO;
using Newtonsoft.Json; 


namespace IndianCensusAnalyser.POCO
{
  public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath,
            string dataHeaders)
        {
            dataMap = new CsvAdaptorFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
        
    }

  

}
