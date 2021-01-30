using static System.Math;

namespace Kinematic_tasks
{
	
	abstract public class Tasks_Ph
	{
		abstract public double Decision();

	}
	public class Task1 : Tasks_Ph
	{
		public double R { get; set; }
		public double I { get; set; }
		private double u = 4 * 3.14 * Pow(10, -7);

		public override double Decision()
		{
			return (u * (I / 2 * (R / 100)))*100000000;
		}
	}
	public class Task2 : Tasks_Ph
	{
		public double V { get; set; }
		public double A { get; set; }
		public double H { get; set; }


		public override double Decision()
		{
			return (V * Pow(10, 6)) * Cos(A) * ((2 * 3.14));
		}
	}
	public class Task3 : Tasks_Ph
	{
		public double V { get; set; }
		public double B { get; set; }

		public override double Decision()
		{
			return ((V * Pow(10, 6) * 1.6 * Pow(10, -19) * B * Pow(10, -3)) / 9.1 * Pow(10, -31));
		}
	}
	public class Task4 : Tasks_Ph
	{
		public double σ1 { get; set; }
		public double σ2 { get; set; }
		private readonly double e0 = 8.85 * Pow(10, -12);
		private double result;

		public override double Decision()
		{
			result = ((σ1 * Pow(10, -9)) / (2 * 1 * e0)) - ((σ2 * Pow(10, -9)) / (2 * 1 * e0));
			return result;
		}
		public double Decision2()
		{
			return ((σ1 * Pow(10, -9)) / (2 * 1 * e0)) + ((σ2 * Pow(10, -9)) / (2 * 1 * e0)); 
		}
	}
	public class Task5 : Tasks_Ph
	{
		public double R1 { get; set; }
		public double R5 { get; set; }
		public double Q1 { get; set; }
		public double Q5 { get; set; }
		public double r1 { get; set; }
		public double r2 { get; set; }
		public double r3 { get; set; }
		private readonly double e0 = 8.85 * Pow(10, -12);
		private readonly double k = 9 * Pow(10, 9);

		public override double Decision()
		{
			if (r1 < R1)
			{
				return 0;
			}
			return 0;
		}
		public double Dec2()
		{
			if (r2 < R1)
			{
				return 0;
			}
			return (Q1 * Pow(10,-9)) / (4 * 3.14 * e0 * Pow((r1 * Pow(10,-2)), 2)) / 10000;

		}
		public double Dec3()
		{
			if (r3 < R1)
			{
				return 0;
			}
			return (Q1 * Pow(10, -9)) + (Q5 * Pow(10, -9)) / (4 * 3.14 * e0 * Pow((r3 * Pow(10,-2)), 2)) / 10000;
		}
	}
}
