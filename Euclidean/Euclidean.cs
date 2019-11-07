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
        public int GetNod(int n, int k)
        {
            int first;
            int second;
            //если входные переменные равны,
            //то нод любой из входных
            if (n == k) { return n; }

            //проверка больше ли n>k
            else if (n > k)
            //если да, то переменные получают соответствующие значения
            //первая f равна n, вторая s равна k
            {
                first = n;
                second = k;
            }
            //если нет, то меняем местами
            else
            {
                first = k;
                second = n;
            }
            int nod;
            //проверка на неравенство остатка нулю
            //если неравен, то запускается этот же метод
            //с новыми значениями
            if (first % second != 0)
            {
                nod = GetNod(second, first % second);
            }
            else nod = second;
            return nod;
        }
        public int GetNod(int n, int k, int l)
        {
            int nod;
            nod = GetNod(n, k);
                if (nod != 1)
                {
                    nod = GetNod(l, nod);
                    return nod;
                }
                else return nod;
        }
        public int GetNod(int n, int k, int l, int m)
        {
            int nod;
            nod = GetNod(n, k);
            if (nod != 1)
            {
                nod = GetNod(l, nod);
                {
                    if (nod != 1)
                    {
                        nod = GetNod(m, nod);
                        return nod;
                    }
                    else return nod;
                }
            }
            else return nod;
        }
        public int GetNod(int n, int k, int l, int m, int p)
        {
            int nod;
            nod = GetNod(n, k);
            if (nod != 1)
            {
                nod = GetNod(l, nod);
                    if (nod != 1)
                    {
                        nod = GetNod(m, nod);
                        if (nod != 1)
                        {
                            nod = GetNod(p, nod);
                            return nod;
                        }
                        else return nod;
                    }
                    else return nod;
            }
            else return nod;
        }
    }
}
