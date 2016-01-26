using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PhoneContext db = new PhoneContext())
            {
                Phone firstPhone = db.Phones.FirstOrDefault();
                firstPhone.Name = "Samsung Galaxy Ace 2";
                db.SaveChanges();

                List<Phone> phones = db.Phones.ToList();
                foreach (Phone ph in phones)
                {
                    Console.WriteLine("Name - {0}, Price - {1}", ph.Name, ph.Price);
                }
                
                
                Console.WriteLine();
                Console.WriteLine("With AsNoTracking method:");
                Phone firstPhone2 = db.Phones.AsNoTracking().FirstOrDefault();
                firstPhone2.Name = "Samsung Galaxy Ace 3";
                db.SaveChanges();

                List<Phone> phones2 = db.Phones.AsNoTracking().ToList();
                foreach (Phone ph in phones2)
                {
                    Console.WriteLine("Name - {0}, Price - {1}", ph.Name, ph.Price);
                }
            }
            Console.ReadLine();
        }
    }
}
