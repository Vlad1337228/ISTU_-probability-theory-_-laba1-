using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomRaspred
{
    class Program
    {
        const double p = 0.87;
        const double q = 1 - p;
        const int m = 6;
        const int count= 100;
        static void Main(string[] args)
        {
            Random r = new Random();
            double[] rand = new double[count];
            double[] func = new double[m];

            for (int i=0;i<100;i++)//рандомные числа
            {
                rand[i] =Math.Round(r.NextDouble(),6);
            }
            
            for(int i=1;i<=m;i++)// функция со значениями
            {
                func[i-1] = p * Math.Pow(q, i-1);
            }
            Out(func);
            Out(Funcc(rand, func));
            Out(rand) ;
        }

        public static void Out(Array array)
        {
            int i = 1;
            foreach(var e in array)
            {
                Console.WriteLine("m"+i+"="+e);
                i++;
            }
            Console.WriteLine();
        }

        public static int[] Funcc(double[] rand, double[] func)
        {
            var mas = new int[m + 1];
            double count=0;
            int index=0;
            double sum = 0;
            for (int i = 0; i < func.Length; i++)
            {
                sum += func[i];
                for(int j=0;j<rand.Length;j++)
                {
                    if(count<rand[j]&&rand[j]<sum)
                    {
                        mas[index]++;

                    }
                }
                count = sum;
                index++;
            }
            return mas;
        }
    }
}
