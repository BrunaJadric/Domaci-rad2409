using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_rad2409
{
    internal class Student : Osoba
    {
        public int godinastudija { get; set; }
        public string smjerstudiranja { get; set; }
        public List<Ispit> lstIspit { get; set; }

        public Student()
        {
            Console.WriteLine("Unesi godinu studija: ");
            godinastudija= int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi smjer studiranja: ");
            smjerstudiranja = Console.ReadLine();
            Console.WriteLine("Unesite broj ispita: ");
            int br=int.Parse(Console.ReadLine());

            for(int i=0;i<br; i++)
            {
                Ispit isp = new Ispit();
                lstIspit.Add(isp);
            }
       
        }

        public void DodajIspit()
        {
            Ispit isp = new Ispit();
            lstIspit.Add(isp);
        }

        public void BrisanjeIspita()
        {
            string prof;
            Console.WriteLine("Unesite prezime prof.: ");
            prof = Console.ReadLine();

            Ispit A = null;
            foreach(Ispit I in lstIspit)
            {
                if (I.profesor==prof)
                {
                    A = I;
                    break;
                }    
                
            }
            if (A==null)
            {
                Console.WriteLine("Taj profesor nije pronađen: ");
            }
            else
            {
                lstIspit.Remove(A);
            }
        }

        public void BrojNepolozenih()
        {
            int br=0;
            foreach (Ispit I in lstIspit)
                if (I.usmeni==0)
                {
                    br++;
                }
            Console.WriteLine("Broj nepoloženih ispita je: {0} ", br);
        }

        public void ProsjekPolozenih()
        {
            double pr = 0;
            int br = 0;
            foreach (Ispit I in lstIspit)
            {
                pr = pr + (I.seminar + I.pismeni + I.usmeni) / 3.0;
                br++;
            }
            pr = pr / br;
            Console.WriteLine("Prosjek položenih ispita je: {0} ", pr);
        }

        public void IspisPodataka()
        {

            Console.WriteLine("Ime: {0}, {1} ", ime, prezime);
            foreach(Ispit I in lstIspit)
            {
                Console.WriteLine("{0}: {1}: {2}: {3}: ", I.predmet, I.profesor, I.seminar, I.pismeni, I.usmeni);
            }
        }
    }

}
