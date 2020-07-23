using System;
using System.Transactions;

namespace Krystek_Lab_2_5
{
	class Program
	{
		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.22.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 2_5
			// =========================================================================

			//Console.WriteLine("Hello World!");

			// Collect 2 Numbers and Do Math
			Console.WriteLine("Enter Number 1 and press 'Enter':");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Number 2 and press 'Enter':");
			int num2 = int.Parse(Console.ReadLine());
			double divided = (double)num1 / (double)num2;
			divided = Math.Round(divided, 2);
			Console.WriteLine("\n");
			Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
			Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
			Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
			Console.WriteLine(num1 + " / " + num2 + " = " + divided);

			// Next Screen
			Console.WriteLine("\nPress 'Enter' to Continue ...");
			Console.ReadLine();
			Console.Clear();

			// Enter Name and Say Hello
			Console.WriteLine("Please enter your name and press 'Enter':");
			string myName = Console.ReadLine();
			Console.WriteLine("\nHello " + myName);

			//Next Screen
			Console.WriteLine("\nPress 'Enter' to Continue ...");
			Console.ReadLine();
			Console.Clear();

			// Collect 3 Numbers and MUltiply Them Together
			Console.WriteLine("Enter 3 numbers, pressing 'Enter' after each one:");
			int inputNum1 = int.Parse(Console.ReadLine());
			int inputNum2 = int.Parse(Console.ReadLine());
			int inputNum3 = int.Parse(Console.ReadLine());
			Console.WriteLine("\nThanks! Multiplying these three numbers together, I get " + (inputNum1 * inputNum2 * inputNum3) + ".");

			//Next Screen
			Console.WriteLine("\nPress 'Enter' to Continue ...");
			Console.ReadLine();
			Console.Clear();

			// Collect an Age and Respond
			Console.WriteLine("How old are you? Please enter a number and press 'Enter':");
			int myAge = int.Parse(Console.ReadLine());
			Console.WriteLine("\nThanks! Hmmmm. You look younger than " + (myAge) + ".");

			//Next Screen
			Console.WriteLine("\nPress 'Enter' to Continue ...");
			Console.ReadLine();
			Console.Clear();

			//End
		}
	}
}
