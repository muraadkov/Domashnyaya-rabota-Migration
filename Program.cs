using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationDZ_18._04._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Visit visit = new Visit();
            InitClass init = new InitClass();
            while (true) {
            init.InitializationPropsInClass(visit);
                if (init.InitializationPropsInClass(visit)) {
                Console.WriteLine("Нажмите ESC для остановки заполнения учёта посетителей.");
                key = Console.ReadKey();
                if(key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                }
            }

            using (var context = new VisitContext())
            {
                context.Visits.Add(visit);
                context.SaveChanges();
            }
        }
    }
}
