using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class studentrecord
    {
        static void Main()
        {
            int sum = 0, avg;
            string[] name = new string[5];
            int[,] studentmarks = new int[5, 5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter the student's name");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter the five subject marks for"+name[i]);
                for(int j=0;j<5;j++)
                {
                    studentmarks[i, j] = int.Parse(Console.ReadLine());


                }
            }
            for(int i=0;i<5;i++)
            {
                sum = 0;
                avg = 0;
                Console.WriteLine("Name:");
                Console.WriteLine(name[i]);
                Console.WriteLine("Marks are");
                for(int j=0;j<5;j++)
                {
                    Console.WriteLine("Mark"+(j-1)+" :"+studentmarks[i, j]);
                    sum = sum + studentmarks[i, j];
                    avg = sum / 5;
                        



                }
                Console.WriteLine("Sum is:" + sum);
                Console.WriteLine("Average is:" + avg);



            }
            //string name;
            //float sum=0;
            //float avg;
            //Console.WriteLine("Enter the name");
            //name = Console.ReadLine();
            //int[] subjectmarks = new int[4];
            //Console.Write("Enter the four subject marks");
            //for(int i=0;i<4;i++)
            //{
            //    subjectmarks[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i=0;i<4;i++)
            //{
            //    sum = sum + subjectmarks[i];
            //}
            //avg = sum / 4;
            //Console.WriteLine("The subject marks are:");
            //for(int i=0;i<4;i++)
            //{
            //    Console.Write(subjectmarks[i]+"\t");
            //}
            //Console.WriteLine("Sum is:" + sum);
            //Console.WriteLine("Average is:" + avg);


        }
    }
}
