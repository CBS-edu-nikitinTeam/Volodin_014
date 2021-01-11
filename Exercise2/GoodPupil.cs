using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Хороший ученик читает");
        }

        public override void Relax()
        {
            Console.WriteLine("Хороший ученик отдыхает");
        }

        public override void Study()
        {
            Console.WriteLine("Хороший ученик учится");
        }

        public override void Write()
        {
            Console.WriteLine("Хороший ученик пишет");
        }
    }
}
