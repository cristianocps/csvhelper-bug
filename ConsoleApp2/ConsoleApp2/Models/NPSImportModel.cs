using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp2
{
    [DataContract]
    public class NPSImportModel
    {
        [Name(CsvHeaders.Name)]
        [Index(1)]
        public string Name { get; set; }

        [Index(0)]
        [Name(CsvHeaders.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Name(CsvHeaders.Email)]
        [Index(2)]
        public string Email { get; set; }
    }
}
