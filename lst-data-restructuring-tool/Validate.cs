using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lst_data_restructuring_tool
{
    class Validate
    {
        public static bool CSVRow(string input)
        {
            bool output = false;

            string[] cells = input.Split(';');

            if (cells.Count() > 2)
            {
                output = true;
            }

            return output;
        }

        public static bool Path(string input)
        {
            bool output = false;

            if (File.Exists(input))
            {
                output = true;
            }

            return output;
        }
    }
}
