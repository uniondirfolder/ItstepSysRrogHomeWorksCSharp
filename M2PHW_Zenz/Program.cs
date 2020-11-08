using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M2PHW_Zenz
{
    class Program
    {
        static int Main(string[] args)
        {
            int output = 0;
            string patern = args[1];
            string filepath = args[0];
            try
            {
                var find = File.ReadAllText(filepath);
                Regex regex = new Regex(patern);
                MatchCollection match = regex.Matches(find);

                //Console.WriteLine(match.Count);
                //Console.ReadKey();
                output = match.Count;
            }
            catch (Exception)
            {
                output = -1;
            }

            return output;
        }
    }
}
