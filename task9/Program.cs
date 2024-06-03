using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new BadPupil("Сидоров");
            Pupil p2 = new GoodPupil("Иванов");
            Pupil p3 = new ExcelentPupil("Петров");
            ClassRoom cl1 = new ClassRoom(p3,p2,p1);
            cl1.OutPut(p3);
            cl1.OutPut(p2);
            cl1.OutPut(p1);
            Console.ReadKey();
        }
    }
}
