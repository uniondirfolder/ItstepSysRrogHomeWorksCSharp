using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PHW_Lag
{
    class Program
    {
        static int Main(string[] args)
        {
            
            if (args.Length != 3)
                return 0;

            int res = 0;
            int i = 0;
            
            try
            {
                i = Int32.Parse(args[0]);
            }
            catch (Exception)
            {
                return 0;
            }
            int j = 0;
            try
            {
                j = Int32.Parse(args[1]);
            }
            catch (Exception)
            {
                return 0;
            }

            char op = '0';
            op = args[2][0];

            switch (op)
            {
                case '*':
                    res = i * j;
                    break;
                case '/':
                    if (j == 0)
                        return 0;
                    res = i / j;
                    break;
                case '-':
                    res = i - j;
                    break;
                case '+':
                    res = i + j;
                    break;
                default:
                    break;
            }

            
            return res;
        }

    }
}
