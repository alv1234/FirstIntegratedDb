using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstIntegratedDb
{
    class Program
    {
        static void Main(string[] args)
        {
            DbProvider db = new DbProvider();
            Console.WriteLine("Hello");
            int i = 1;
            while (i != 0)
            {
                Console.WriteLine("\nPlease choose the following...\n\t1 - query all \n\t2 - insert data\n\t0 - exit");
                i = Int32.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        foreach (var item in db.QueryAll())
                        {
                            Console.WriteLine(String.Format("{0}-{1}", item.Id, item.Name));
                        }
                        break;
                    case 2:
                        string temp = "NewName" + new Random().Next(1000);
                        db.Add(temp);
                        Console.WriteLine(String.Format("{0} was added to list", temp));
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
