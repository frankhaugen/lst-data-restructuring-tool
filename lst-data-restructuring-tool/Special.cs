using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lst_data_restructuring_tool
{
    class Special
    {
        public static string SingleDoubleTabs(string input)
        {
            string output;

            output = input.Replace("\t\t\t", ";");
            output = output.Replace("\t\t", ";");
            output = output.Replace("\t", ";");

            return output;
        }


        public static string CleanCSVRows(string input)
        {
            string output = "";



            return output;
        }
    }
}
