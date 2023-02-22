using System;using System.Numerics;namespace _02UnderstandingTypes{	public class class2CenturiesConvert	{		public class2CenturiesConvert()		{						Console.WriteLine("Please input the number of centuries you want to convert( an integer): ");			int centries = int.Parse(Console.ReadLine());			checked
			{
                
				BigInteger years = (BigInteger)centries * 100;
                BigInteger days = years * 365;
                BigInteger hours = days * 24;
                BigInteger minutes = hours * 60;
                BigInteger seconds = minutes * 60;
                BigInteger milliseconds = seconds * 1000;
                BigInteger microseconds = milliseconds * 1000;
                BigInteger nanoseconds = microseconds * 1000;

				Console.WriteLine($"{centries} centries =  {years} years = {days} days = {hours} hours = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
				Console.ReadLine();
            }		}	}}