using System;

namespace ExSesiune2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triunghi[] triunghiuri = new Triunghi[] {new Triunghi (new Punct(1, 1), new Punct(2, 2), new Punct(3, 3)),
            new Triunghi (new Punct(1, 3), new Punct(1, 2), new Punct(3, 2))};
            GeometryUtils.Translate(1, 1, triunghiuri);

            for (int i = 0; i < triunghiuri.Length; i++)
            {
                Console.WriteLine(triunghiuri[i].A.X);
                Console.WriteLine(triunghiuri[i].A.Y);
                Console.WriteLine(triunghiuri[i].B.X);
                Console.WriteLine(triunghiuri[i].B.Y);
                Console.WriteLine(triunghiuri[i].C.X);
                Console.WriteLine(triunghiuri[i].C.Y);
            }
        }
    }
}
