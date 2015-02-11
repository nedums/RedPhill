using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyTest
{
    public class Triangle
    {
        private int _Side1Length;
        private int _Side2Length;
        private int _Side3Length;
        public Triangle(int side1Length, int side2Length, int side3Length)
        {
            _Side1Length = side1Length;
            _Side2Length = side2Length;
            _Side3Length = side3Length;
        }
        private bool IsTrangle()
        {
            var max = (_Side1Length > _Side2Length ? (_Side1Length > _Side3Length ? _Side1Length : _Side3Length) : (_Side2Length > _Side3Length ? _Side2Length : _Side3Length));
            var sumOFOther = (_Side1Length > _Side2Length ? (_Side1Length > _Side3Length ? _Side2Length + _Side3Length : _Side1Length + _Side2Length) : (_Side2Length > _Side3Length ? _Side1Length + _Side3Length : _Side1Length + _Side2Length));
            return (_Side1Length > 0 && _Side2Length > 0 && _Side3Length > 0 && sumOFOther > max);
        }
        /// <summary>
        /// Return the Type of the trangle
        /// 
        /// </summary>
        /// <returns></returns>
        public TriangleType GetTriangleType()
        {
            try
            {


                if (!IsTrangle())
                    return TriangleType.Error;
                else
                {
                    if (_Side1Length == _Side2Length && _Side1Length == _Side3Length)
                        return TriangleType.Equilateral;
                    else if (_Side1Length == _Side2Length || _Side1Length == _Side3Length || _Side2Length == _Side3Length)
                        return TriangleType.Isosceles;
                    else
                        return TriangleType.Scalene;
                }
            }
            catch (Exception e)
            {
                //return TriangleType.Error;
                throw e;
            }

        }
    }
}