using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4.kodepos
{
    internal class KodePos
    {
        public String kelurahan;
        public int kodepos;
        public List<KodePos> listKodepost = new List<KodePos>();
        public KodePos(String a = "", int k = 0)
        {
            this.kelurahan = a;
            this.kodepos = k;
        }

        public void setKodePost()
        {
            this.listKodepost.Add(new KodePos("Kota Bandung", 40111));
            this.listKodepost.Add(new KodePos("Kota Bogor", 16111));
            this.listKodepost.Add(new KodePos("Kota Depok", 16411));
            this.listKodepost.Add(new KodePos("Kota Bekasi", 17111));
            this.listKodepost.Add(new KodePos("Kota Sukabumi", 43111));
            this.listKodepost.Add(new KodePos("Kota Cirebon", 45111));
            this.listKodepost.Add(new KodePos("Kota Tasikmalaya", 46111));
            this.listKodepost.Add(new KodePos("Kota Banjar", 46311));
            this.listKodepost.Add(new KodePos("Kota Cimahi", 40511));
            this.listKodepost.Add(new KodePos("Kota Sumedang", 45311));
        }

        public void getKodePos()
        {
            Console.WriteLine("Kelurahan\tKode Pos");
            foreach (KodePos k in this.listKodepost)
            {
                string kelPad = k.kelurahan.PadRight(15);
                Console.Write(kelPad + "\t" + k.kodepos);
                Console.WriteLine();
            }

        }

    }
}
