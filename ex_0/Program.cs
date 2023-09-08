using ex_0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_0.Reposetory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayOption();
            Console.ReadLine();
        }
        public static void DisplayOption()
        {
            Console.WriteLine("1. Show All Oparetor");
            Console.WriteLine("2. Insert Oparetor");
            Console.WriteLine("3. Update Oparetor");
            Console.WriteLine("4. Delete Oparetor");

            var index = int.Parse(Console.ReadLine());
            Show(index);
        }
        public static void Show(int index)
        {
            Oparetorreport oparetorreport1 = new Oparetorreport();
            if (index == 1)
            {
                var opretortList = oparetorreport1.GetAll();
                if (opretortList.Count() == 0)
                {
                    Console.WriteLine("======================");
                    Console.WriteLine("No data found");
                    Console.WriteLine("======================");
                    DisplayOption();
                }
                else
                {
                    foreach (var item in oparetorreport1.GetAll())
                    {
                        Console.WriteLine($"operator Id: {item.OparetorId}, Name: {item.OparetorName}, Age: {item.OparetorAge}");
                    }
                    Console.WriteLine("===============================");
                    DisplayOption();
                }
            }
            else if (index == 2)
            {
                Console.WriteLine("============================");
                Console.Write("Name :");
                string name = Console.ReadLine();

                Console.Write("Age :");
                int age = Convert.ToInt32(Console.ReadLine());

                int maxId = oparetorreport1.GetAll().Any() ? oparetorreport1.GetAll().Max(x => x.OparetorId) : 0;

                Oparetor Ooparetor = new Oparetor
                {
                    OparetorId = maxId + 1,
                    OparetorName = name,
                    OparetorAge = age
                };
                oparetorreport1.Insert(Ooparetor);
                Console.WriteLine("Data Inserted successfully!!!");
                Console.WriteLine("=================================");
                DisplayOption();
            }
            else if (index == 3)
            {
                Console.WriteLine("==================================");
                Console.Write("Enter operator  Id to Update: ");
                int id = int.Parse(Console.ReadLine());
                var doparetor = oparetorreport1.GetById(id);

                if (doparetor == null)
                {
                    Console.WriteLine("======================");
                    Console.WriteLine("Client Id is invalid!!!");
                    Console.WriteLine("======================");
                    DisplayOption();
                }
                else
                {
                    Console.WriteLine($"Update Info for operator  Id : {id}");
                    Console.WriteLine("===================================");
                    Console.Write(" operator Name :");
                    string name = Console.ReadLine();

                    Console.Write(" operator Age :");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Oparetor Ooparetor = new Oparetor
                    {
                        OparetorId = id,
                        OparetorName = name,
                        OparetorAge = age
                    };
                    oparetorreport1.Update(Ooparetor);
                    Console.WriteLine("Data Updated Successfully!!!");
                    Console.WriteLine("====================================");
                    DisplayOption();
                }
            }
            else if (index == 4)
            {
                Console.WriteLine("==================================");
                Console.Write("Enter operator Id to Delete: ");
                int id = int.Parse(Console.ReadLine());
                var opreaor = oparetorreport1.GetById(id);

                if (opreaor == null)
                {
                    Console.WriteLine("======================");
                    Console.WriteLine("operator Id is invalid!!!");
                    Console.WriteLine("======================");
                    DisplayOption();
                }
                else
                {
                    oparetorreport1.Delete(id);
                    Console.WriteLine("Data Deleted Successfully!!!");
                    Console.WriteLine("===============================");
                    DisplayOption();
                }

            }
        }
    }
}
