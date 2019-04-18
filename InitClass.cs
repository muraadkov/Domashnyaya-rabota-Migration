using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationDZ_18._04._2019
{
    public class InitClass
    {
        public bool InitializationPropsInClass(Visit visit)
        {
            try {
            Console.WriteLine("Когда зашёл посетитель? ДД.ММ.ГГ ЧЧ:ММ:CC");
            visit.TimeOfJoin = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException format)
            {
                throw format;
            }
            try {
            Console.WriteLine("Когда вышел посетитель? ДД.ММ.ГГ ЧЧ:ММ:CC");
            visit.TimeOfLeave = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException format)
            {
                throw format;
            }
            Console.WriteLine("Имя посетителя: ");
            visit.Name = Console.ReadLine();
            if(visit.Name.Trim(' ') == "")
            {
                Console.WriteLine("Не может быть пустого имени.");
                return false;
            }
            else {
            Console.WriteLine("Номер удостоверения: ");
            visit.IDCardNumber = Console.ReadLine();
            if (visit.IDCardNumber.Trim(' ') == "")
            {
                 Console.WriteLine("Не может быть пустого удостоверения личности.");
                    return false;
            }
                else {

            Console.WriteLine("Цель визита: ");
            visit.PointOfVisit = Console.ReadLine();
                    if (visit.PointOfVisit.Trim(' ') == "")
                    {
                        Console.WriteLine("Не может быть пустой цели визита");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
