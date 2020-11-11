using CsvHelper;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using CsvHelper.Configuration;

namespace ConsoleApp2
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var records = new List<NPSImportModel>()
            {
            };

            foreach (int value in Enumerable.Range(0, 1000))
            {
                records.Add(new NPSImportModel { Email = $"lorem@ipsum{value}.com.br", Name = $"{value}1 - Lorem ipsum dolor sit amet", PhoneNumber = $"{value}55199836622288" });
            }

            MemoryStream writeStream = new MemoryStream();
            using StreamWriter writer = new StreamWriter(writeStream);
            using (CsvWriter csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                BufferSize = 4096 * 2,
                Encoding = Encoding.UTF8,
                ShouldQuote = (row, context) => true,
                ShouldSkipRecord = (data) => false
            }))
            {
                writeStream.Position = 0;
                csvWriter.WriteRecords(records);

                writeStream.Position = 0;
                var csvText = Encoding.UTF8.GetString(writeStream.ToArray());

                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../", "results.csv"), csvText, Encoding.UTF8);
            }
        }
    }
}
