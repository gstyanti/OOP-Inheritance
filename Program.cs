using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            person Person  = new person  ();
            Console.WriteLine("===Data Person===");
            Console.Write("Nama: ");
            string Name = Console.ReadLine();
            Console.Write("Umur: ");
            string Age = Console.ReadLine();
            Console.WriteLine();

            teacher Teacher = new teacher();
            Console.WriteLine("===Data Guru===");
            Console.Write("Nama Guru: ");
            string TeacherName = Console.ReadLine();
            Console.Write("ID Guru: ");
            string TeacherId = Console.ReadLine();
            Console.Write("Subjek Mapel: ");
            string Subject = Console.ReadLine();
            Console.WriteLine();

            student Student = new student();
            Console.WriteLine("===Data Siswa===");
            Console.Write("Nama Siswa: ");
            string StudentName = Console.ReadLine();
            Console.Write("ID Siswa: ");
            string Studentid=Console.ReadLine();
            Console.Write("Umur Siswa: ");
            string StudentAge = Console.ReadLine();
            Console.Write("Email Siswa: ");
            string StudentEmail = Console.ReadLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
