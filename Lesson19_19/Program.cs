using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Code=1, Mark="IBM", Type="Intel", RAM=16, Price=30000, Stock=5},
                new Computer(){Code=2, Mark="Apple", Type="Intel", RAM=32, Price=70000, Stock=10},
                new Computer(){Code=3, Mark="Samsung", Type="AMD", RAM=8, Price=50000, Stock=15},
                new Computer(){Code=4, Mark="Lenovo", Type="Intel", RAM=8, Price=35000, Stock=20},
                new Computer(){Code=5, Mark="Asus", Type="AMD", RAM=16, Price=25000, Stock=35},
                new Computer(){Code=6, Mark="Toshiba", Type="Intel", RAM=32, Price= 60000, Stock=30},
                new Computer(){Code=7, Mark="Dell", Type="Intel", RAM=8, Price=20000, Stock=25},
                new Computer(){Code=8, Mark="HP", Type="Intel", RAM=16, Price=45000, Stock=2}
            };

            Console.WriteLine("Введите тип процессора");
            string type = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.Type == type).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем RAM");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.RAM >= ram).ToList();
            Print(computers2);

            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.Type);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer e in gr)
                {
                    Console.WriteLine($"{e.Code} {e.Mark} {e.Type} {e.RAM} {e.Price} {e.Stock}");
                }
            }

            Console.WriteLine("Cамый дорогой компьютер");
            Computer computer5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer5.Code} {computer5.Mark} {computer5.Type} {computer5.RAM} {computer5.Price} {computer5.Stock}");

            Console.WriteLine("Cамый бюджетный компьютер");
            Computer computer6 = computers.OrderByDescending(x => x.Price).LastOrDefault();
            Console.WriteLine($"{computer6.Code} {computer6.Mark} {computer6.Type} {computer6.RAM} {computer6.Price} {computer6.Stock}");


            Console.WriteLine(computers.Any(x => x.Stock > 30));
             
            Console.ReadKey();


         
        }  
            
            static void Print(List<Computer> computers)
            {
                foreach (Computer e in computers)
                {
                    Console.WriteLine($"{e.Code} {e.Type} {e.Mark} {e.RAM} {e.Price} {e.Stock}");
                }
                Console.WriteLine();

            }
       
        }
    }
                



        
           
        







              




      


