using Labs1;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        int A = 10;
        int B = 20;
        partial_Class_1 obj = new partial_Class_1(A, B);
        int kqcong = obj.Cong(A, B);
        System.Console.WriteLine(kqcong);
        int kqtru = obj.Tru(A, B);
        System.Console.WriteLine(kqtru); 
        int kqnhan = obj.Nhan(A, B);
        System.Console.WriteLine(kqnhan);       
        int kqchia = obj.Chia(A, B);
        System.Console.WriteLine(kqchia);
    }


}

   