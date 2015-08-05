using System;

namespace lab1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the value in Degrees : ");
			String s = Console.ReadLine ();
			int d = int.Parse (s);
			double r = d * 6.28 / 360;
			Console.WriteLine ("The Radian Value : " + r);
			Console.Write("Enter the value in Radians : ");
			s = Console.ReadLine ();
			r = double.Parse (s);
			double de = r * 360 / 6.28;
			Console.WriteLine (" The Value in degrees : "+de);

		}
	}
}
