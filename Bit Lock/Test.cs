using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BitLock
{
    static void Main()
    {
        string eghtNumbers = Console.ReadLine();
        string[] egthNs = eghtNumbers.Split(' ');
        int counter = 0;
        int columToChek = 0;
        int positiones = 0;
        int bitToChek = 0;
        char bit = ' ';
        string binNumber;
        List<int> bitsResults = new List<int>();
        char[,] matrix = new char[8, 12];
        for (int i = 0; i < 8; i++)
        {
            Int16 number = Int16.Parse(egthNs[i]);
            binNumber = Convert.ToString(number, 2).PadLeft(12, '0');
            for (int l = i; l <= i; l++)
            {
                for (int j = 11, k = 0; k < 12 && j > -1; k++, j--)
                {
                    matrix[l, k] = binNumber[j];
                }
            }
        }
        while (true)
        {
            string comand = Console.ReadLine();
            string[] stringArr = comand.Split(' ');
            if (comand == "end")
            {
                break;
            }
            if (stringArr[0] == "check")
            {
                columToChek = int.Parse(stringArr[1]);
                for (int i = 0; i < 8; i++)
                {
                    if (matrix[i, columToChek] == '1')
                    {
                        bitToChek++;
                    }
                }
                bitsResults.Add(bitToChek);
                bitToChek = 0;
            }
            else
            {
                columToChek = int.Parse(stringArr[0]);
                positiones = int.Parse(stringArr[2]) % 12;
                if (stringArr[1] == "right")
                {
                    for (int i = 0; i < positiones; i++)
                    {
                        for (int k = 0; k < 12 - 1; k++)
                        {
                            if (k == 0)
                            {
                                bit = matrix[columToChek, k];
                                matrix[columToChek, k] = matrix[columToChek, k + 1];
                            }
                            else
                            {
                                matrix[columToChek, k] = matrix[columToChek, k + 1];
                            }
                            counter = k;
                        }
                        matrix[columToChek, counter + 1] = bit;
                    }
                }
                else
                {
                    for (int i = 0; i < positiones; i++)
                    {
                        for (int k = 11; k > 0; k--)
                        {
                            if (k == 11)
                            {
                                bit = matrix[columToChek, k];
                                matrix[columToChek, k] = matrix[columToChek, k - 1];
                            }
                            else
                            {
                                matrix[columToChek, k] = matrix[columToChek, k - 1];
                            }
                        }
                        matrix[columToChek, counter] = bit;
                    }
                }
            }
        }
        foreach (var item in bitsResults)
        {
            Console.WriteLine(item);
        }
        string[] someString = new string[12];
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                someString[j] = matrix[i, j].ToString();
            }
            int[] someNumber = new int[someString.Length];
            int value = 0;
            for (int l = 0; l < someNumber.Length; l++)
            {
                someNumber[l] = int.Parse(someString[l]);
            }
            for (int z = 0; z < someNumber.Length; z++)
            {
                value += Convert.ToInt16(someNumber[z] * (Math.Pow(2, z)));
            }
            Console.Write("{0}" + " ", value);
        }
    }
}
