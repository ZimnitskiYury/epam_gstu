using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
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
            //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
            if (nod != 1)
            {
                nod = GetNod(l, nod);
                {
                    //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
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
            //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
            if (nod != 1)
            {
                nod = GetNod(l, nod);
                //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
                if (nod != 1)
                    {
                        nod = GetNod(m, nod);
                    //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
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
        public int GetNodStein(int n, int k, out double ts)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int nod;
            int first;
            int second;
            if (n == 0)
            {
                stopWatch.Stop();
                ts = stopWatch.Elapsed.TotalMilliseconds;
                return k; //первое условие бинарного алгоритма

            }
            if (k == 0)
            {
                stopWatch.Stop();
                ts = stopWatch.Elapsed.TotalMilliseconds;
                return n; //первое условие бинарного алгоритма
            }
            if (n == k)
            {
                stopWatch.Stop();
                ts = stopWatch.Elapsed.TotalMilliseconds;
                return n; 
            } //второе условие бинарного алгоритма

            //проверка больше ли n>k
            if (n > k)
            //если да, то переменные получают соответствующие значения
            //первая first равна n, вторая second равна k
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
            //проверка третьего условия бинарного алгоритма
            if (first % 2 == 0 && second % 2 == 0)
            {
                first /= 2;
                second /= 2;
                nod = 2 * GetNodStein(first, second, out _);
            }
            //проверка 5го условия бинарного алгоритма
            else if (first % 2 == 1 && second % 2 == 1)
            {
                nod = GetNodStein((first - second) / 2, second, out _);
            }
            //проверка 4го условия бинарного алгоритма
            else if (first % 2 == 0)
            {
                nod = GetNodStein(first / 2, second, out _);
            }
            else
            {
                nod = GetNodStein(first, second / 2, out _);
            }
            stopWatch.Stop();
            ts = stopWatch.Elapsed.TotalMilliseconds;
            return nod;
        }
    }
}
