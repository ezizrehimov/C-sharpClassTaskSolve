using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTaskLab15
{
    internal class Student
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Fakulte { get; set; }
        public int[] ImtahanadekBal { get; set; }
        public char[] Neticeler { get; set; } = new char[5];

        public Student(string ad, string soyad, string fakulte, int[] imtahanadekBal)
        {
            Ad = ad;
            Soyad = soyad;
            Fakulte = fakulte;
            ImtahanadekBal = imtahanadekBal;
            //Neticeler = new char[ImtahanadekBal.Length];

        }


        public void checkExam(Exam exam)
        {
            for (int i = 0; i < ImtahanadekBal.Length; i++)
            {
                char netice = 'F';

                if (exam.ImtahanBali[i] > 17)
                {
                    int sum = ImtahanadekBal[i] + exam.ImtahanBali[i];

                    if (sum > 90)
                    {
                        netice = 'A';
                    }
                    else if (sum > 80)
                    {
                        netice = 'B';
                    }
                    else if (sum > 70)
                    {
                        netice = 'C';
                    }
                    else if (sum > 60)
                    {
                        netice = 'D';
                    }
                    else if (sum > 50)
                    {
                        netice = 'E';
                    }
                    else
                    {
                        netice = 'F';
                    }
                }

                Neticeler[i] = netice;


            }

        }


        public void info(Exam exam)
        {
            Console.WriteLine($"{Ad} , {Soyad}, {Fakulte}");

         for(int i = 0; i < ImtahanadekBal.Length; i++)
            {
                Console.WriteLine("Imtahanadek bal: " + ImtahanadekBal[i]);
                Console.WriteLine("Imtahanadaki bal: "+ exam.ImtahanBali[i]);
                Console.WriteLine("Umumi netice: " + Neticeler[i]);
            }
        }

    }
}
