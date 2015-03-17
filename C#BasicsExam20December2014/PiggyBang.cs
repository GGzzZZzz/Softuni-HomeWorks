using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class PiggyBang
{
    static void Main()
    {
        int priceOfTank = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());
        int moneyForParty = partyDays * 5;
        int daysMoneySave = 30 - partyDays;
        int monthlyBalans = (daysMoneySave * 2) - moneyForParty;
        double monthneed = (double)priceOfTank  / monthlyBalans;
        int result = (int)Math.Ceiling(monthneed);
        int yearsneed = result / 12;
        int months = result % 12; 
        if (monthlyBalans <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine(yearsneed + " years, " + months + " months");
        }
    }
}
