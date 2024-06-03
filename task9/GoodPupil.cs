using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string surname) : base(surname) { }
        public override void Study()
        {
            Console.WriteLine($"{Surname} учится хорошо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Surname} читает достаточно быстро!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Surname} пишет с небольшими ошибками!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Surname} отдыхает, смотря телевизор!");
        }
    }
}
