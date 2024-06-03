using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    abstract class Pupil
    {
        public string Surname { get; set; }
        public Pupil(string surname)
        {
            Surname = surname;
        }
        abstract public void Study();
        abstract public void Read();
        abstract public void Write();
        abstract public void Relax();

    }
}
