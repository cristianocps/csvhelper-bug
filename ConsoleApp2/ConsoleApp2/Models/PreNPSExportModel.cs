using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp2
{
    [DataContract]
    public class PreNPSExportModel
    {
        [Name(CsvHeaders.PhoneNumber)]
        
        public string PhoneNumber { get; set; }
    }
}
