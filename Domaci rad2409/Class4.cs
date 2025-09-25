using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_rad2409
{
    public static class Admin
    {
        public static void Unos(List<Student> students)
        {
            int n;
            Console.WriteLine("Unesite broj studenata: ");
            n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Student student = new Student();
                students.Add(student);
            }
        }

        public static void Najlosiji(List<Student> students)
        {
            Student min = students[0];
            foreach (Student student in students)
            {
                if (student.BrojNepolozenih() > min.BrojNepolozenih())
                {
                    min = student;
                }
            }
            min.IspisPodataka;

        }
    }
}
