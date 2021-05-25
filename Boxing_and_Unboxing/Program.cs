//Boxing & in boxing
using System;
//int i = 123;
//object o = (object) i;// boxing
//o = 123
//i = (int) 0; // unboxing
class testUnboxing
{
    static void Main()
    {
        int i = 123;
        object o = i // implicit boxing
    }
    try
    {
     int j = (short) o;  
       //int j = int o;             // attempt to unbox
    Console.WriteLine("Unboxing ok.");

     }
    catch (InvalidCastException e)
    {
    Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
    }
  }
}
