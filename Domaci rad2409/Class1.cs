using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_rad2409
{
    public class Ispit
    {
        public string predmet { get; set; }
        public string profesor { get; set; }
        public int seminar { get; set; }
        public int pismeni { get; set; }
        public int usmeni { get; set; }

        public Ispit()
        {
            Console.Write("Unesi naziv predmeta: ");
            predmet = Console.ReadLine();
            Console.WriteLine("Unesi prezime profesora: ");
            profesor = Console.ReadLine();
            Console.WriteLine("Unesi broj bodova iz seminarskog: ");
            seminar = int.Parse(Console.ReadLine());

            if (seminar == 0)
            {
                pismeni = 0;
                usmeni = 0;
            }
            else
            {
                Console.WriteLine("Unesi broj bodova iz pismenog: ");
                pismeni = int.Parse(Console.ReadLine());
            }
            if (pismeni == 0)
            {
                usmeni = 0;
            }
            else
            {
                Console.WriteLine("Unesite broj bodova iz usmenog: ");
                usmeni = int.Parse(Console.ReadLine());
            }
        }

    }
}
