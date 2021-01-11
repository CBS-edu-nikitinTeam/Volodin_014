using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class ClassRoom
    {
        private List<Pupil> pupils;
        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = new List<Pupil>(pupils);
        }

        public void HowPupilsDoing()
        {
            foreach(Pupil pupil in pupils)
            {
                pupil.Study();
                pupil.Write();
                pupil.Read();
                pupil.Relax();
                Console.WriteLine("\n");
            }
        }
    }
}
