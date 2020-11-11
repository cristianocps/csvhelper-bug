using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp2
{
    public class NPSExportModel
    {
        [Name(CsvHeaders.Name)]

        public string Name { get; set; }

        [Name(CsvHeaders.PhoneNumber)]
        public string Phone { get; set; }

        [Name(CsvHeaders.Email)]

        public string Email { get; set; }

        [Name(CsvHeaders.NpsUrl)]
        public string NpsUrl { get; set; }
    }
}
