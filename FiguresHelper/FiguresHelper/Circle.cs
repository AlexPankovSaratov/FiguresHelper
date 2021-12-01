using System;

namespace FiguresHelper
{
	public class Circle : Figure
	{
		private double _radius;
		public double Radius { 
			get 
			{ 
				return _radius; 
			} 
			set 
			{
				_radius = value;
				CheckValidationParameters();
			} 
		}

		public Circle(double radius)
		{
			_radius = radius;
			CheckValidationParameters();
		}
		public override double GetArea()
		{
			return Math.PI * Math.Pow(_radius, 2);
		}
		private	void CheckValidationParameters()
		{
			if (_radius <=  0) throw new ArgumentOutOfRangeException("The radius of the circle must be greater than 0");
		}
	}
}
