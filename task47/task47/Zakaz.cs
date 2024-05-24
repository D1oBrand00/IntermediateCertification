using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task47
{
    class Zakaz
    {
        string fam;
        int size;
        string comfort;
        public string Fam { get { return fam; } set { fam = value; } }
        public int Size{ get { return size; } set { size = value; } }
        public string Comfort{ get { return comfort; } set { comfort = value; } }
        public Zakaz() { }
        public Zakaz(string fam)
        {
            this.fam = fam;
        }
        public Zakaz(string fam,int size):
            this(fam)
        {
            this.size = size;
        }
        public Zakaz(string fam, int size,string comfort):
            this(fam,size)
        {
            this.comfort = comfort;
        }
        public void Show()
        {
            Console.Write($"Фамилия: {fam}\nКол-во мест в номере: {size}\nКомфорт: {comfort}\n\n");
        }
    }
}
