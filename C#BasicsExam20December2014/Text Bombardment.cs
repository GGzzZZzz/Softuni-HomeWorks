using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Practice
{
    static void Main()
    {
        string text = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        int rows = (int)Math.Ceiling(text.Length / (decimal)N);
        string newText = Console.ReadLine();
        string[] theText = newText.Split(' ');
        List<int> bombs = new List<int>();
        for (int i = 0; i < theText.Length; i++)
        {
            bombs.Add(int.Parse(theText[i]));
        }
        char[,] matrix = new char[rows, N];
        for (int i = 0, letter = 0; i < rows; i++)
        {
            for (int j = 0; letter < text.Length && j < N; letter++, j++)
            {
                matrix[i, j] = text[letter];
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < bombs.Count; k++)
                {
                    if (j == bombs[k] && matrix[i, j] != ' ')
                    {
                        matrix[i, j] = ' ';
                    }
                    else if (j == bombs[k] && matrix[i, j] == ' ' && i > 0)
                    {
                        bombs.RemoveAt(k);
                    }
                }
            }
        }
        char[] transverer = new char[text.Length];
        for (int i = 0, k = 0; i < rows; i++)
        {
            for (int j = 0;k<transverer.Length && j < N; k++,j++)
            {
                transverer[k] = matrix[i, j];
            }
        }
        string bombedText = new string(transverer);
        Console.WriteLine(bombedText);
    }
}
