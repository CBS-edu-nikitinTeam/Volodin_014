using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil()).HowPupilsDoing();
        }
    }
}
