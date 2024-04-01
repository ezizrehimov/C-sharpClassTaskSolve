using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTaskLab15
{
    internal class Exam
    {
        public string[] ImtahanAdi { get; set; }
        public int[] ImtahanBali { get; set; }


        public Exam(string[] imtahanAdi, int[] imtahanBali)
        {
            ImtahanAdi = imtahanAdi;
            ImtahanBali = imtahanBali;
        }
    }
}
