using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //StringBuilder builder = new StringBuilder("Hello World",50);

            //for (int i = 0; i < builder.Length; i++)
            //    Console.WriteLine(i);


            //StringBuilder builder1 = new StringBuilder("Hello world");
            ////builder1.Insert(5,"$");
            ////builder1.Remove(1, 0);
            //builder1.Replace("l","e",1,5);
            //Console.WriteLine(builder1);

            // 1: print 1 upto n numbers
            //for(int i=0;i<=100;i++)
            // {
            //     Console.WriteLine(i);
            // }
            // //2: print m upto n numbers where m<n
            // int n = 100;
            // for(int M = 20; M <n;M++)
            // {
            //     Console.WriteLine(M);
            // }
            //3,4:print All Even/Odd Numers 1uptoN

            //int n = 1000;
            //Console.WriteLine("Even Numbers :");
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //Console.WriteLine("\nOdd Numbers :");
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //Console.WriteLine();


            //5,6 M,N print All Even/Odd Numers M upto N where (M<N) 

            //    int k = 10;
            //    int m = 20;

            //    for (k = 1;k<=m;k++)
            //    {

            //        if (k%2==0)
            //        {
            //            Console.WriteLine(k +"EVEN" );
            //        }

            //        if (k%2!=0)
            //        {
            //            Console.WriteLine(k + "ODD ");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            //7

            //int s = 32;
            //Console.WriteLine("Divisible by:"+s);
            //for (int i = 1; i < 100; i++)
            //{
            //    if( i%s==0)
            //    {
            //        Console.WriteLine(i + " ");
            //    }
            //}


            //8,9

            //int s = 5;//Mutiplication Table

            //int k = 20;//Table Rows
            //Console.WriteLine("Mutiplication Table:");

            //for (int i = 1; i <= s; i++)
            //{
            //    for (int j = 1; j <= k; j++)
            //    {
            //        int temp = i * j;
            //        Console.WriteLine(j + "*" + i + "=" + temp + "\t");

            //    }
            //    Console.Write("\n");
            //    Console.WriteLine("\t");
            //}

            //10

            //int N = 5;
            //int temp = 0;
            //Console.WriteLine("Sum of Numbers");

            //    //int sn = N * (1 + N) / 2;//sum of Number Formula
            //    //Console.WriteLine(sn);


            //for (int i = 1; i <= N; i++)
            //    temp = temp + i;
            //   temp += i;
            //Console.WriteLine(temp);

            //11,12

            //int N = 5;
            //int temp = 0;
            //Console.WriteLine("Sum of Even Numbers");
            //for(int i=1;i<=N;i++)
            //{
            //    temp = temp + i;
            //    if(temp%2==0)
            //    {
            //        Console.WriteLine(temp+ " ");
            //    }

            //}
            //Console.WriteLine("Sum of ODD Numbers");
            //for (int i = 1; i <= N; i++)
            //{
            //    temp = temp + i;
            //    if (temp % 2 != 0)
            //    {
            //        Console.WriteLine(temp + " ");
            //    }

            //}

            //13

            //int N = 100;
            //int k = 3;
            //Console.WriteLine("Sum of ODD Numbers");
            //for (int i = 1; i <= N; i++)
            //{
            //    if(i%k==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //14

            //int N = 20;
            //int k = 3;
            //int M = 5;
            //Console.WriteLine("Sum ");
            //for (int i = 1; i <= N; i++)
            //{
            //    StringBuilder @string = new StringBuilder(50);

            //    if (i % k == 0 && i % M == 0)
            //    {
            //        Console.WriteLine("Fizz,Bizz");

            //    }
            //    else if (i % k == 0 )
            //    {
            //        Console.WriteLine("Fizz");

            //    }
            //   else if (i % M == 0)
            //    {

            //        Console.WriteLine("Bizz");
            //    }

            //    else
            //    {
            //        Console.WriteLine(i);
            //    }



            //}


            //15:Factorial
            //int k = 6;

            //int temp3 = 1;

            //for (int i=1;i<=k;i++)
            //{

            //    temp3 *= i;


            //    Console.WriteLine(temp3);
            //}


            Console.WriteLine("Enter the Subject count  in Current Sum ");
            
          
            int SubjectCount =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Subject count  in Current Sum :" +SubjectCount);

            Console.WriteLine("Enter the Subject mark");
            int temp = 0;


            int[] Marks;
            Marks = new int[SubjectCount];

            //for(int i=0;i<Marks.Length;i++)
            //{
            //    temp += i;
            //    Console.WriteLine("Subjects Total Marks" +temp);
            //  int  temp2 = temp / Marks.Length;
            //    Console.WriteLine("Subject  Avg Marks"+temp2);
            //}
         

           

        }





    }
}
