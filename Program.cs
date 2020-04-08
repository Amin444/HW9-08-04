using System;

namespace HW9_08_04
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] z = { "Amin", "task", "House" };
            foreach (var item in z)
            {
                System.Console.WriteLine(item);
            }


            ArrayHelper.Pop(ref z);
            
            System.Console.WriteLine("Deleted Pop");
            foreach (var item in z)
            {
                System.Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    static class ArrayHelper
    {
        public static string Pop(ref string[] ar)
        {
            string[] nar = new string[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            string end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
         public static int Pop(ref int[] ar)
        {
            int[] nar = new int[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            int end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
          public static double Pop(ref double[] ar)
        {
            double[] nar = new double[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            double end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
          public static decimal Pop(ref decimal[] ar)
        {
            decimal[] nar = new decimal[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            decimal end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
          public static float Pop(ref float[] ar)
        {
            float[] nar = new float[ar.Length - 1];
            for (int x = 0; x < ar.Length - 1; x++)
            {
                nar[x] = ar[x];
            }
            float end = ar[ar.Length - 1];
            ar = nar;
            return end;
        }
        
    }
}