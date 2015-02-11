using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ReadifyTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class RedPill : IRedPill
    {

        public Guid WhatIsYourToken()
        {
            return new Guid("e69c8770-78b0-4b53-8e81-df7fc16f8261");

        }
        /// <summary>
        /// Reverse each words on a phrase
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public string ReverseWords(string words)
        {
            Word word = new Word(words);
            return word.Reverse();


        }
        /// <summary>
        /// Return the nth FibonacciNumber
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public long FibonacciNumber(long position)
        {

            FibonacciNumber fibNumber = new FibonacciNumber();
            if (fibNumber != null)
                return fibNumber.GetNthFibonacciNumber(position);
            else
                throw new FaultException("Error occured ");


        }
        /// <summary>
        /// Return the type of an Triangle 
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            Triangle triangle = new Triangle(a,b,c);
            return triangle.GetTriangleType();

            
        }

    }
}
