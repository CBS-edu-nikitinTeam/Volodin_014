using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class ExcelentPupil : Pupil
    {
        public override void Read()
        {
           Console.WriteLine("Превосходный ученик читает");
        }

        public override void Relax()
        {
            Console.WriteLine("Превосходный ученик отдыхает");
        }

        public override void Study()
        {
            Console.WriteLine("Превосходный ученик учится");
        }

        public override void Write()
        {
            Console.WriteLine("Превосходный ученик пишет");
        }
    }
}
