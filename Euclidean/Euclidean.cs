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
        public int GetNod(int n, int k, out double timeEuclid)
        {
            int first;  //переменная для большего значения
            int second; //переменная для меньшего значения
            int nod;    //переменная для НОД
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (n > k) //если n больше k, то переменные получают соответствующие значения                                     
            {
                first = n;  //первая first равна n
                second = k; //вторая second равна k
            }
            else            //если нет, то меняем местами
            {
                first = k;
                second = n;
            }
            if (first == 0)
            {
                nod = second;
            }
            else if (second == 0)
            {
                nod = first;
            }
            else if (first == second) //если входные переменные равны, то НОД любая из них
            {
                nod = first;
            }
            else if (first % second != 0)//проверка на неравенство остатка нулю
            //если неравен, то запускается этот же метод
            //с новыми значениями
            {
                nod = GetNod(second, first % second, out _);
            }
            else
            {
                nod = second;
            }
            stopWatch.Stop();
            timeEuclid = stopWatch.Elapsed.TotalMilliseconds;
            return nod;
        }
        public int GetNod(int n, int k, int l)
        {
            int nod;
            nod = GetNod(n, k, out _);
            //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
            if (nod != 1)
            {
                nod = GetNod(l, nod, out _);
                return nod;
            }
            else return nod;
        }
        public int GetNod(int n, int k, int l, int m)
        {
            int nod;
            nod = GetNod(n, k, out _);
            //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
            if (nod != 1)
            {
                nod = GetNod(l, nod, out _);
                {
                    //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
                    if (nod != 1)
                    {
                        nod = GetNod(m, nod, out _);
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
            nod = GetNod(n, k, out _);
            //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
            if (nod != 1)
            {
                nod = GetNod(l, nod, out _);
                //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
                if (nod != 1)
                {
                    nod = GetNod(m, nod, out _);
                    //проверка на НОД равную 1, если равна единице, то продолжать нет смысла
                    if (nod != 1)
                    {
                        nod = GetNod(p, nod, out _);
                        return nod;
                    }
                    else return nod;
                }
                else return nod;
            }
            else return nod;
        }
        public int GetNodStein(int n, int k, out double timeStein)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int nod;
            int first;
            int second;
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
            if (n == 0)
            {
                nod = k; //первое условие бинарного алгоритма
            }
            else if (k == 0)
            {
                nod = n; //первое условие бинарного алгоритма
            }
            else if (n == k)
            {
                nod = n;
            } //второе условие бинарного алгоритма
            //проверка третьего условия бинарного алгоритма
            else if (first % 2 == 0 && second % 2 == 0)
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
            timeStein = stopWatch.Elapsed.TotalMilliseconds;
            return nod;
        }
        public void GetAlgsTime(int n, int k, out string[] masX, out double [] masY)
        {
            GetNod(n, k, out double algsEuclidTime);
            GetNodStein(n, k, out double algsSteinTime);
            string [] algsName= { "EuclidAlgs", "SteinAlgs" };
            double [] algsTime = { algsEuclidTime, algsSteinTime };
            masX = algsName;
            masY = algsTime;
        }
    }
}
