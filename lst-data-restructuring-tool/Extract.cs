using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace lst_data_restructuring_tool
{
    class Extract
    {
        /// <summary>
        /// Extracts csv data from a given csv source string
        /// </summary>
        /// <param name="input">CSV data string</param>
        /// <returns></returns>
        public static string[] CSVRows(string input)
        {
            string[] output = input.Split('\n');

            return output;
        }

        public static string[] CSVCells(string input, char delimiter)
        {
            string[] output = input.Split(delimiter);

            return output;
        }

        public static string FileText(string path)
        {
            string output = File.ReadAllText(path);

            return output;
        }

        public static DataTable CSV(string input, bool hasHeadings = false)
        {
            DataTable output = new DataTable();
            DataColumn outputColumn;
            DataRow outputRow;

            string[] allLines = input.Split('\n');

            if (hasHeadings)
            {
                string[] cells = allLines[0].Split(';');
                foreach (string cell in cells)
                {
                    output.Columns.Add(cell);
                }
            }
            else
            {
                string[] cells = allLines[0].Split(';');
                for (int i = 1; i < cells.Count(); i++)
                {
                    output.Columns.Add("Column " + i);
                }
            }



            return output;


        }
    }
}
