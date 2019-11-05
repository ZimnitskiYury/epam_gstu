using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    public class Euclidean
    {
        //метод для получения Нод двух чисел
        public virtual int GetNod(int n, int k)
        {
            int f;
            int s;
            //если входные переменные равны,
            //то нод любой из входных
            if (n == k) { return n; }

            //проверка больше ли n>k
            else if (n > k)
            //если да, то переменные получают соответствующие значения
            //первая f равна n, вторая s равна k
            {
                f = n;
                s = k;
            }
            //если нет, то меняем местами
            else
            {
                f = k;
                s = n;
            }
            int nod;
            //проверка на неравенство остатка нулю
            //если неравен, то запускается этот же метод
            //с новыми значениями
            if (f % s != 0)
            {
                nod = GetNod(s, f % s);
            }
            else nod = s;
            return nod;
        }
    }
}
