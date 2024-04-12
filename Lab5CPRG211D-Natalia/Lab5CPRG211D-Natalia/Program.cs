using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CPRG211D_Natalia
{
	internal class Program
	{
		class Circle
		{
			double radius;

			public void SetRadius(double potentialRadius) 
			{
				if (potentialRadius <= 0)
				{
					throw new InvalidRadiusException("Radius must be greater than 0.");
				}
				else
				{
					radius = potentialRadius;
				}
			}

			public override string ToString()
			{
				if (radius > 0) 
				{
					return $"Circle radius = {radius}";
				}
				else 
				{
					return "Circle radius was not set.";
				}
				
			}

		}

		class InvalidRadiusException:Exception 
		{
			public InvalidRadiusException():base() { }
			public InvalidRadiusException(string message):base(message) { }
		}

		static void Main(string[] args)
		{
			Circle circle = new Circle();
			Console.WriteLine("Please enter a radius for your circle:");
			double radius = Convert.ToDouble(Console.ReadLine());

			try
			{
				circle.SetRadius(radius);
			}
			catch (InvalidRadiusException ir) 
			{
				Console.WriteLine(ir);
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine(circle.ToString());
			}

			Console.ReadLine();
		}
	}
}
