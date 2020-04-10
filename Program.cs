using System;

namespace HW9_08_04
{
    class Program
    {
        static void Main()
        {


            string[] z = { "Amin", "task", "House" };
            foreach (var item in z)
            {
                System.Console.WriteLine(item);
            }
            ArrayHelper.Pop(ref z);


            foreach (var item in z)
            {
                System.Console.WriteLine(item);
            }
            ////////////////////////////////////////////
            System.Console.WriteLine("-------Anouther point!--------");
            string[] a = { "Alif", "Loptop", "Academy" };
            ArrayHelper.Push(ref a, "Avengers");
            foreach (var resilt in a)
            {
                System.Console.WriteLine(resilt);
            }

            ////////////////////////////////////////////////
            string[] aw = { "Asd", "ASDA", "DSA" };
            string ret = ArrayHelper.Shift(ref aw);
            foreach (var g in aw)
            {
                System.Console.WriteLine(g);
            }
            System.Console.WriteLine($"deleted {ret}");


             ArrayHelper.UnShift(ref a, 8);
            foreach (var z in a)
            {
                System.Console.WriteLine(z);
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
        static public void Push(ref string[] a, string add)
        {
            string[] nadd = new string[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                nadd[i] = a[i];

            }
            nadd[nadd.Length - 1] = add;
            a = nadd;

        }
        static public void Push(ref double[] a, double add)
        {
            double[] nadd = new double[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                nadd[i] = a[i];

            }
            nadd[nadd.Length - 1] = add;
            a = nadd;


        }

        static public void Push(ref int[] a, int add)
        {
            int[] nadd = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                nadd[i] = a[i];

            }
            nadd[nadd.Length - 1] = add;
            a = nadd;
        }
        static public void Push(ref decimal[] a, decimal add)
        {
            decimal[] nadd = new decimal[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                nadd[i] = a[i];

            }
            nadd[nadd.Length - 1] = add;
            a = nadd;
        }

        static public void Push(ref float[] a, float add)
        {
            float[] nadd = new float[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                nadd[i] = a[i];

            }
            nadd[nadd.Length - 1] = add;
            a = nadd;

        }

        public static string Shift(ref string[] s)
        {
            string[] del = new string[s.Length - 1];
            for (int i = 0; i < del.Length; i++)
            {
                del[i] = s[i + 1];
            }
            string ret = s[0];
            s = del;
            return ret;
        }

        public static double Shift(ref double[] s)
        {
            double[] del = new double[s.Length - 1];
            for (int i = 0; i < del.Length; i++)
            {
                del[i] = s[i + 1];
            }
            double ret = s[0];
            s = del;
            return ret;
        }

        public static int Shift(ref int[] s)
        {
            int[] del = new int[s.Length - 1];
            for (int i = 0; i < del.Length; i++)
            {
                del[i] = s[i + 1];
            }
            int ret = s[0];
            s = del;
            return ret;
        }

        public static decimal Shift(ref decimal[] s)
        {
            decimal[] del = new decimal[s.Length - 1];
            for (int i = 0; i < del.Length; i++)
            {
                del[i] = s[i + 1];
            }
            decimal ret = s[0];
            s = del;
            return ret;
        }

        public static float Shift(ref float[] s)
        {
            float[] del = new float[s.Length - 1];
            for (int i = 0; i < del.Length; i++)
            {
                del[i] = s[i + 1];
            }
            float ret = s[0];
            s = del;
            return ret;
        }
                 public static void UnShift(ref int[] ut, int se)
        {
            int[] nar = new int[ut.Length + 1];
            nar[0] = se;
            for (int x = 0; x < nar.Length-1; x++)
            {
                nar[x+1] = ut[x];
            }
            ut = nar;
        }
              public static void UnShift(ref string[] ut, string se)
        {
            string[] nar = new string[ut.Length + 1];
            nar[0] = se;
            for (int x = 0; x < nar.Length-1; x++)
            {
                nar[x+1] = ut[x];
            }
            ut = nar;
        }
              public static void UnShift(ref double[] ut, double se)
        {
            double[] nar = new double[ut.Length + 1];
            nar[0] = se;
            for (int x = 0; x < nar.Length-1; x++)
            {
                nar[x+1] = ut[x];
            }
            ut = nar;
        }
              public static void UnShift(ref decimal[] ut, decimal se)
        {
            decimal[] nar = new decimal[ut.Length + 1];
            nar[0] = se;
            for (int x = 0; x < nar.Length-1; x++)
            {
                nar[x+1] = ut[x];
            }
            ut = nar;
        }
              public static void UnShift(ref float[] ut, float se)
        {
            float[] nar = new float[ut.Length + 1];
            nar[0] = se;
            for (int x = 0; x < nar.Length-1; x++)
            {
                nar[x+1] = ut[x];
            }
            ut = nar;
        }
    }


}