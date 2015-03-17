using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CheetSheet
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long VertikalStartnum = long.Parse(Console.ReadLine());
        long HorisontalStartnum = long.Parse(Console.ReadLine());
        for (long i = 0; i < N; i++)
        {
            for (long z = 0; z < C; z++)
            {
                if (i == (N - 1) && z == (C - 1))
                {
                    Console.Write("{0}", (HorisontalStartnum + z) * (VertikalStartnum + i));
                }
                else if (z == (C - 1))
                {
                    Console.Write("{0}{1}", (HorisontalStartnum + z) * (VertikalStartnum + i), "\r\n");
                }
                else
                {
                    Console.Write("{0}{1}",(HorisontalStartnum + z) * (VertikalStartnum + i)," ");
                }
            }
        }
    }
}
