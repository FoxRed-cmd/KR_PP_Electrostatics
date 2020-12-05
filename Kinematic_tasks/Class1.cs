using static System.Math;

namespace Kinematic_tasks
{
	
	abstract public class Tasks_Ph
	{
		abstract public double Decision();

	}
	public class Task1 : Tasks_Ph
	{
		public double Q1 { get; set; }
		public double Q2 { get; set; }
		public double e0 = 8.88 * Pow(10, -12);

		public override double Decision()
		{
			return ((Q1 * Pow(10, -9)) + (Q2 * Pow(10, -9))) / e0;
		}
	}
}
