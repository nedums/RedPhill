using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyTest
{
    public class FibonacciNumber
    {
        private long _Index;
        private long _Number;

        private List<FibonacciNumber> _FibonacciNumberList;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fibonacciNumber"></param>
        public FibonacciNumber(long index, long fibonacciNumber)
        {
            _Index = index;
            _Number = fibonacciNumber;
        }
        public FibonacciNumber()
        {

            try
            {
                if (_FibonacciNumberList == null)
                {
                    _FibonacciNumberList = new List<FibonacciNumber>();
                    long i = 0;
                    long lastNumber, secondLastNumber;
                    lastNumber = 1;
                    secondLastNumber = 1;
                    while (i <= long.MaxValue)
                    {
                        
                        if (i == 0)
                            _FibonacciNumberList.Add(new FibonacciNumber(0, 0));
                        else if (i == 1)
                            _FibonacciNumberList.Add(new FibonacciNumber(1, 1));
                        else if (i == 2)
                            _FibonacciNumberList.Add(new FibonacciNumber(2, 1));
                        else
                        {
                            var currentFibonacciNumber = lastNumber + secondLastNumber;
                            _FibonacciNumberList.Add(new FibonacciNumber(i, currentFibonacciNumber));
                            secondLastNumber = lastNumber;
                            lastNumber = currentFibonacciNumber;
                            //
                            if (i == 92)
                                break;
                        }

                        i++;
                    }
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
        /// <summary>
        /// Get The FibonacciNumber at the given position
        /// </summary>
        /// <param name="position">position of the Series</param>
        /// <returns></returns>
        public long GetNthFibonacciNumber(long position)
        {
            if (position >= _FibonacciNumberList.Count || position < -_FibonacciNumberList.Count)
                throw new Exception("Fib > 92 ");

            var result = _FibonacciNumberList.Where(f => f._Index == Math.Abs(position)).FirstOrDefault();
            if (result != null)
            {
                //Odd negative are positive 
                var multiplier = (position > 0) ? 1 : (long)Math.Pow(-1, position - 1);
                return result._Number * multiplier;
            }
            else
                throw new Exception("Number not found in the list.");
        }
    }
}