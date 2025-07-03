using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace YourNamespace
{
    class Program

    {
        #region Q1
        //public static void change(int x)
        //{
        //    x = 10;
        //} 
        #endregion
        #region Q2
        //public static int Sub(ref int[] arr) {
        //    int s = 0;
        //    foreach (int i in arr) {
        //        s -= i;
        //    }
        //    return s;
        //}
        #endregion
        #region Q3
        //static void Sum_Sub(int a, int b,int c,int e, out int sum, out int sub)
        //{
        //    sum = a + b+c+e;
        //    sub = a - b-c-e;
        //}
        #endregion
        #region Q4
        //public static int sum(int n)
        //{
        //    int sum = 0;
        //    while (n != 0)
        //    {
        //        sum += n % 10;
        //        n /= 10;
        //    }
        //    return sum;
        //}
        #endregion
        #region Q5
        //public static bool IsPrime(int n) {
        //        for (int i = 2; i < n; i++)
        //        {
        //            if (n % i == 0)
        //               return false;
        //        }

        //        return true;

        //}
        #endregion
        #region Q6
        //public static void max_min(int[] arr, out int max, out int min)
        //{
        //    max = arr[0];
        //    min = arr[0];
        //    for (int i = 1; i < arr.Length; i++) {
        //        if (arr[i] < min) min = arr[i];
        //        if (arr[i] > max) max = arr[i];
        //    }
        //}
        #endregion
        #region Q7
        //public static int fac(int n)
        //{
        //    int f = 1;
        //    for (int i = 1; i < n; i++) {
        //        f *= i;
        //    }
        //    return f;
        //}
        #endregion
        #region Q8
        //public static string change(string n, int i, char c)
        //{
   
        //    char[] charachter = n.ToCharArray();
        //    charachter[i] = c;
        //    string result = new string(charachter);
        //    return result;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
            //---->اى تغير يحصل جوه الفنكشن على القيمة مش بيحس بيها القيمة الاصليه اللى فى مين   by value
            //----> لما يبعت بواسطه ريفرينس بيبعت القيمه زاد نفسها فبيحصل تغير فى المين by reference
            //int x = 5;
            //change(x);
            //Console.WriteLine("Value=" + x);
            #endregion
            #region Q2
            //Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //no diff betw useing  by value and by reference beca i use  Reference type parameters if i use by value i modify and copy on heap 
            //or by reference i use the origin value
            //int[]n = { 9, 4, 2 };
            //int r=Sub(ref n);
            //Console.WriteLine( r);
            #endregion
            #region Q3
            //Console.Write("enter n1:");
            //int.TryParse(Console.ReadLine(), out int n1);
            //Console.Write("enter n2:");
            //int.TryParse(Console.ReadLine(), out int n2);
            //Console.Write("enter n3:");
            //int.TryParse(Console.ReadLine(), out int n3);
            //Console.Write("enter n4:");
            //int.TryParse(Console.ReadLine(), out int n4);
            //int sum, sub;
            //Sum_Sub(n1,n2,n3,n4,out sum, out sub);

            //Console.WriteLine("summation : " + sum);
            //Console.WriteLine("subtracting : " + sub);
            #endregion
            #region Q4
            //Console.Write("enter n:");
            //int.TryParse(Console.ReadLine(), out int n);
            //int r = sum(n);
            //Console.WriteLine($"sum:{n} is: {r}");
            #endregion
            #region Q5
            //Console.Write("enter n1:");
            //int.TryParse(Console.ReadLine(), out int n1);
            //bool r= IsPrime(n1);
            //Console.WriteLine(r);
            #endregion
            #region Q6
            //int[] arr = {2,3,4,5,6,7};
            //max_min(arr, out int max, out int min);
            //Console.WriteLine("Min:" + min);
            //Console.WriteLine("Max:" + max);
            #endregion
            #region Q7
            //Console.Write("enter n:");
            //int.TryParse(Console.ReadLine(), out int n);
            //int r = fac(n);
            //Console.WriteLine($"fac:{n} is: {r}");
            #endregion
            #region Q8
            //Console.Write("enter name:");
            //string n = Console.ReadLine();
            //string c = change(n, 0, 'a'); 
            //Console.WriteLine("Change: " + c); 
            #endregion
        }
    }
}