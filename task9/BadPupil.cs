using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class BadPupil : Pupil
    {
        public BadPupil(string Surname) : base(Surname) { }
        public override void Study()
        {
            Console.WriteLine($"{Surname} учится плохо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Surname} читает очень медленно!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Surname} пишет с большим количеством ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Surname} отдыхает, играя в компьютерные игры!");
        }
    }
}
