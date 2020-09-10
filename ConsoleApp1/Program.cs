using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AA ob = new AA();
            ob.f();
        }
            
        class AA{
            void frand(int[] A) {
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    A[i] = r.Next(100);
                }
            }

            void sort(int[] A)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (A[i] > A[i + 1])
                        {
                            A[i + 1] = A[i] + A[i + 1];
                            A[i] = A[i + 1] - A[i];
                            A[i + 1] = A[i + 1] - A[i];
                        }
                    }                        
                }
            }

            void output(int[] A)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(A[i] + " ");
                }

                Console.WriteLine();

            }

            public void f()
            {
                int[] A = new int[10];
                frand(A);
                output(A);
                sort(A);
                output(A);

            }
        }
       
    }
}
