using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Плохой ученик читает");
        }

        public override void Relax()
        {
            Console.WriteLine("Плохой ученик отдыхает");
        }

        public override void Study()
        {
            Console.WriteLine("Плохой ученик учится");
        }

        public override void Write()
        {
            Console.WriteLine("Плохой ученик пишет");
        }
    }
}
