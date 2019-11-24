using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace task01
{
    /// <summary>
    /// Euclidean alghorithm
    /// </summary>
    public class Euclidean
    {
        /// <summary>
        /// Calculates greatest common divisor (GCD) of two numbers
        /// </summary>
        /// <param name="n">A first number</param>
        /// <param name="k">A second number</param>
        /// <param name="timeEuclid">The time spent on the algorithm</param>
        /// <returns>Greatest common divisor</returns>
        public int GetNod(int n, int k, out double timeEuclid)
        {
            Stopwatch stopWatch = new Stopwatch();      
            stopWatch.Start();                         
            n = Math.Abs(n);                           
            k = Math.Abs(k);                           
            int first;                                 
            int second;                                
            int nod;                                    

            if (n > k)                                                                    
            {
                first = n;                             
                second = k;                             
            }
            else                                        
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
            else if (first == second)                   
            {
                nod = first;
            }
            else if (first % second != 0)              
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
        /// <summary>
        /// Calculates greatest common divisor (GCD) of three numbers
        /// </summary>
        /// <param name="n">A first number</param>
        /// <param name="k">A second number</param>
        /// <param name="l">A third number</param>
        /// <returns>Greatest common divisor</returns>
        public int GetNod(int n, int k, int l)
        {
            int nod;                                    
            nod = GetNod(n, k, out _);                  
            
            if (nod != 1)                               
            {
                nod = GetNod(l, nod, out _);            
                return nod;
            }
            else
            {
                return nod;                            
            }
        }
        /// <summary>
        /// Calculates greatest common divisor (GCD) of four numbers
        /// </summary>
        /// <param name="n">A first number</param>
        /// <param name="k">A second number</param>
        /// <param name="l">A third number</param>
        /// <param name="m">A fourth number</param>
        /// <returns>Greatest common divisor</returns>
        public int GetNod(int n, int k, int l, int m)
        {
            int nod;                                    
            nod = GetNod(n, k, out _);                  
            
            if (nod != 1)                               
            {
                nod = GetNod(l, nod, out _);            
                {
                    
                    if (nod != 1)                       
                    {
                        nod = GetNod(m, nod, out _);    
                        return nod;
                    }
                    else
                    {
                        return nod;                     
                    }
                }
            }
            else
            {
                return nod;                             
            }
        }
        /// <summary>
        /// Calculates greatest common divisor (GCD) of five numbers
        /// </summary>
        /// <param name="n">A first number</param>
        /// <param name="k">A second number</param>
        /// <param name="l">A third number</param>
        /// <param name="m">A fourth number</param>
        /// <param name="p">A fives number</param>
        /// <returns>Greatest common divisor</returns>
        public int GetNod(int n, int k, int l, int m, int p)
        {
            int nod;                                    
            nod = GetNod(n, k, out _);                              
            if (nod != 1)                               
            {
                nod = GetNod(l, nod, out _);            
                
                if (nod != 1)                           
                {
                    nod = GetNod(m, nod, out _);        
                    
                    if (nod != 1)                       
                    {
                        nod = GetNod(p, nod, out _);    
                        return nod;
                    }
                    else
                    {
                        return nod;                     
                    }
                }
                else
                {
                    return nod;                         
                }
            }
            else
            {
                return nod;                             
            }
        }
        /// <summary>
        /// Calculates greatest common divisor (GCD) of two numbers using the Stein algorithm
        /// </summary>
        /// <param name="n">The first number</param>
        /// <param name="k">The second number</param>
        /// <param name="timeStein">The time spent on the algorithm</param>
        /// <returns>Greatest common divisor</returns>
        public int GetNodStein(int n, int k, out double timeStein)
        {
            Stopwatch stopWatch = new Stopwatch();      
            stopWatch.Start();                          
            n = Math.Abs(n);                            
            k = Math.Abs(k);                            
            int nod;                                    
            int first;                                  
            int second;                                 
            if (n > k)                                  
            {
                first = n;                              
                second = k;                             
            }
            else                                        
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
            else if (first == second)                   
            {
                nod = first;
            }            
            else if (first % 2 == 0 && second % 2 == 0) 
            {
                first /= 2;
                second /= 2;
                nod = 2 * GetNodStein(first, second, out _);
            }            
            else if (first % 2 == 1 && second % 2 == 1) 
            {
                nod = GetNodStein((first - second) / 2, second, out _);
            }
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
        /// <summary>
        /// Creates 2 arrays with data of time spent by the algorithmes
        /// </summary>
        /// <param name="n">The first number</param>
        /// <param name="k">The second number</param>
        /// <param name="masX">The first array of names of alghorithmes</param>
        /// <param name="masY">The second array of time spent by alghorithmes</param>
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
