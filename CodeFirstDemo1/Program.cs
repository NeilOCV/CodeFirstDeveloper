using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var Db=new StudentDbContext())
            {
                Console.Write("Enter student name: ");
                var name = Console.ReadLine();
                var st = true;

                var record = new Student() { Name = name, Statuss = st };

                Console.WriteLine("Creating and accessing StudentDBContext");
                Db.Students.Add(record);
                Db.SaveChanges();

                var query = from d in Db.Students
                            select d;
                Console.WriteLine("Id\t\tName\t\tStatur");
                Console.WriteLine("---------------------------------------------------------------------------------");

                foreach (var data in query)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", data.Id, data.Name, data.Statuss);
                }

                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("Press enter....  Now!");
                Console.ReadLine();
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public bool Statuss { get; set; }
    }
}
