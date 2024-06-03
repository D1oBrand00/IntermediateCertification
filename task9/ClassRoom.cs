using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class ClassRoom
    {
        public ClassRoom() { }
        public ClassRoom(Pupil obj1) { }
        public ClassRoom(Pupil obj1, Pupil obj2) { }
        public ClassRoom(Pupil obj1, Pupil obj2, Pupil obj3) { }
        public void OutPut(Pupil pp)
        {
            Console.WriteLine($"Ученик {pp.Surname}:");
            pp.Study();
            pp.Read();
            pp.Write();
            pp.Relax();
            Console.WriteLine();
        }


    }
}    
