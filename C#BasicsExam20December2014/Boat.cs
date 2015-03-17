using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Boat
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int bodyOfBoat = (N - 1) / 2;
        int fullBoat = N + bodyOfBoat;
        int size = N * 2;
        int counter = 1;
        Console.WriteLine("{0}{1}{2}", new string('.', N - counter), new string('*', counter), new string('.', N));
        for (int i = 0; i < N - 2; i++)
        {
            if (i <= ((N - 2) / 2))
            {
                counter++;
                counter++;
                Console.WriteLine("{0}{1}{2}", new string('.', N - counter), new string('*', counter), new string('.', N));
            }
            else
            {
                counter--;
                counter--;
                Console.WriteLine("{0}{1}{2}", new string('.', N - counter), new string('*', counter), new string('.', N));
            }
        }
        counter = 1;
        Console.WriteLine("{0}{1}{2}", new string('.', N - counter), new string('*', counter), new string('.', N));
        for (int i = 0; i < (N-1)/2; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('.',i),new string('*',size - (i*2)));
        }
    }
}
