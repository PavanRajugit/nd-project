using System;
using System.Collections.Generic;
using System.IO;

namespace CodingTest.UI.Services
{
    public class CsvService
    {
        private readonly LoggerService _logger;

        public CsvService(LoggerService logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Reads a CSV file and converts each line into a list of values.
        /// </summary>
        public List<List<string>> LoadCsv(string filePath)
        {
            var rows = new List<List<string>>();

            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("CSV file not found.", filePath);

                foreach (var line in File.ReadLines(filePath))
                {
                    // Split by comma
                    var values = new List<string>(line.Split(','));
                    rows.Add(values);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error loading CSV: " + ex.Message);
            }

            return rows;
        }
    }
}
