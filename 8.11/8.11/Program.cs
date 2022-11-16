using System;
using System.Xml.Linq;


public class MainClass
{
    public static void Main()
    {
        int[,] a = new int[12, 3];
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                a[i,j] = random.Next(10000);
            }
        }
        Console.WriteLine("Работник\tМесяц");
        Console.WriteLine(" \t  1\t  2\t  3");
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i} \t {a[i - 1, 0]} \t {a[i - 1, 1]}\t {a[i - 1, 2]}");
        }
        int num;
        restart:
        restart1:
        Console.WriteLine("");
        Console.WriteLine("Выберите желаемую операцию:");
        Console.WriteLine("1) общую сумму, выплаченную за квартал всем работникам");
        Console.WriteLine("2) зарплату, полученную за квартал каждым работником");
        Console.WriteLine("3) общую зарплату всех работников за каждый месяц");
        Console.WriteLine("");
        Console.WriteLine("Выбор:");
        num = int.Parse(Console.ReadLine());
        if (num<1||num>3)
        {
            Console.WriteLine("Такой операции не существует,повтирите выбор;");
            goto restart;
        }
        if(num==1)
        {
            int sum=a.Cast<int>().Sum();
            Console.WriteLine("Общая сумма, выплаченная за квартал всем работникам:");
            Console.WriteLine(sum);
            Console.WriteLine("");
            goto restart1;
        }
        if (num == 2)
        {
            int individualSumOfQuarter = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        individualSumOfQuarter = individualSumOfQuarter + a[i, 0] + a[i, 1] + a[i, 2];
                    }
                    Console.WriteLine($"Зарплата работника {i + 1} за квартал составила {individualSumOfQuarter} руб.");
                    Console.WriteLine("");
                    goto restart1;
                }
            }
           
          
            
        }
        if (num==3)
        {
            int allSumPerMonth1 = 0;
            int allSumPerMonth2 = 0;
            int allSumPerMonth3 = 0;
            for (int i = 0; i < 12; i++)
            {
                allSumPerMonth1 += a[i,0];
                if (i >= 11)
                {
                    for (i = 0; i < 12; i++)
                    {
                        allSumPerMonth2 += a[i, 1];
                        if (i >= 11)
                        {
                            for (i = 0; i < 12; i++)
                            {
                                allSumPerMonth3 += a[i, 2];
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Зарплата всех работников за первый месяц составила {allSumPerMonth1} руб.");
            Console.WriteLine($"Зарплата всех работников за второй месяц составила {allSumPerMonth2} руб.");
            Console.WriteLine($"Зарплата всех работников за третий месяц составила {allSumPerMonth3} руб.");
            Console.WriteLine("");
            goto restart1;

        }



    }
}
    



