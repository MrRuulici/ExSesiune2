using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSesiune2
{
    public static class GeometryUtils
    {
        public static void Translate(int Ox, int Oy, Triunghi[] triunghiuri)
        {
            for(int i=0; i<triunghiuri.Length; i++)
            {
                triunghiuri[i].A.X = triunghiuri[i].A.X + Ox;
                triunghiuri[i].A.Y = triunghiuri[i].A.Y + Oy;
                triunghiuri[i].B.X = triunghiuri[i].B.X + Ox;
                triunghiuri[i].B.X = triunghiuri[i].B.Y + Oy;
                triunghiuri[i].C.X = triunghiuri[i].C.X + Ox;
                triunghiuri[i].C.X = triunghiuri[i].C.Y + Oy;
            }
        }
        public static void Translate(int Ox, int Oy, Dreptunghi[] dreptunghiuri)
        {
            for (int i = 0; i < dreptunghiuri.Length; i++)
            {
                dreptunghiuri[i].A.X = dreptunghiuri[i].A.X + Ox;
                dreptunghiuri[i].A.X = dreptunghiuri[i].A.X + Oy;
                dreptunghiuri[i].B.X = dreptunghiuri[i].B.X + Ox;
                dreptunghiuri[i].B.X = dreptunghiuri[i].B.X + Oy;
            }
        }
    }
}
