using System;
namespace _02UnderstandingTypes
{
	public class class1NumberOfBytes
	{
	    public class1NumberOfBytes()
	    {
            //int c = 987654321;
            //int d = c*c;
            ///Console.WriteLine($"The result of d by  is: {d}");
            //double a = 1.0;
            //double b = 0.0;

            //Console.WriteLine($"The result of divide double by zero is: {a / b}");

            	Console.WriteLine("Data Type | Bytes in Memory | Minimum Value | Maximum Value");
            	Console.WriteLine("-------------------------------------------------------------");

            	Console.WriteLine("sbyte     | {0,-15} | {1,-13} | {2,-13}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            	Console.WriteLine("byte      | {0,-15} | {1,-13} | {2,-13}", sizeof(byte), byte.MinValue, byte.MaxValue);
            	Console.WriteLine("short     | {0,-15} | {1,-13} | {2,-13}", sizeof(short), short.MinValue, short.MaxValue);
            	Console.WriteLine("ushort    | {0,-15} | {1,-13} | {2,-13}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            	Console.WriteLine("int       | {0,-15} | {1,-13} | {2,-13}", sizeof(int), int.MinValue, int.MaxValue);
            	Console.WriteLine("uint      | {0,-15} | {1,-13} | {2,-13}", sizeof(uint), uint.MinValue, uint.MaxValue);
            	Console.WriteLine("long      | {0,-15} | {1,-13} | {2,-13}", sizeof(long), long.MinValue, long.MaxValue);
            	Console.WriteLine("ulong     | {0,-15} | {1,-13} | {2,-13}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            	Console.WriteLine("float     | {0,-15} | {1,-13} | {2,-13}", sizeof(float), float.MinValue, float.MaxValue);
            	Console.WriteLine("double    | {0,-15} | {1,-13} | {2,-13}", sizeof(double), double.MinValue, double.MaxValue);
            	Console.WriteLine("decimal   | {0,-15} | {1,-13} | {2,-13}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

            	Console.ReadLine();
            }
      }
}

