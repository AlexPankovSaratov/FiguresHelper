using System;
using System.Collections.Generic;
using System.Linq;

namespace FiguresHelper
{
	public class Triangle : Figure
	{
		private double _sideA;
		private double _sideB;
		private double _sideC;

		public double SideA
		{
			get
			{
				return _sideA;
			}
			set
			{
				_sideA = value;
				CheckValidationParameters();
			}
		}
		public double SideB
		{
			get
			{
				return _sideB;
			}
			set
			{
				_sideB = value;
				CheckValidationParameters();
			}
		}
		public double SideC
		{
			get
			{
				return _sideC;
			}
			set
			{
				_sideC = value;
				CheckValidationParameters();
			}
		}

		public Triangle(double sideA, double sideB, double sideC)
		{
			_sideA = sideA;
			_sideB = sideB;
			_sideC = sideC;
			CheckValidationParameters();
		}
		public override double GetArea()
		{
			double halfPerimeter = (_sideA + _sideB + _sideC) / 2;
			return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
		}
		public bool TriangleIsRightAngled()
		{
			var sides = new List<double> { _sideA, _sideB, _sideC };
			if (sides.Distinct().Count() < 3) return true;
			return false;
		}
		private void CheckValidationParameters()
		{
			if(_sideA <= 0  || _sideB <= 0  || _sideC <= 0) 
				throw new ArgumentOutOfRangeException("The sides of the triangle must be greater than 0");
		}
	}
}
