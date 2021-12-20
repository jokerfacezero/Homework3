using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num1
{

  
    class Complex
    {
        public double im;
        public double re;

        

        public Complex Plus (Complex x2)
        {
            Complex result = new Complex();
            result.im = x2.im + this.im;
            result.re = x2.re + this.re;
            return result;
        }
        public string ToString ()
        {
            return re + " + " + im + "i";
        }

        public Complex MultiCation (Complex x2)
        {
            Complex result = new Complex ();
            result.re = this.re * x2.re;
            result.im = this.re * x2.im;

            /*
            x3.im1 = this.im * x2.re;
            x3.re1 = this.im * -x2.im;
            x3.im = x3.im + x3.im1;
            x3.re = x3.re + x3.re1;
            */
            return result;
        }

        public Complex Minus(Complex x2)
        {
            Complex result = new Complex();
            result.im =   this.im - x2.im;
            result.re =   this.re - x2.re;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            
            bool flag = false;
            while(!flag) {
                Complex complex1 = new Complex();
                complex1.re = 1;
                complex1.im = 2;
                Complex complex2 = new Complex();
                complex2.re = 3;
                complex2.im = -4;
               
                Console.WriteLine("Введите действие, которое хотите совершить \n" +
                    "Введите 0 чтобы выйти из программы");
                string task = (Console.ReadLine());
                switch (task)
                {
                    case "+":
                        Complex resultSum = complex1.Plus(complex2);
                        Console.WriteLine("Сложение " + resultSum.ToString());
                        Console.ReadKey();
                        break;
                    case "-":
                        Complex resultMinus = complex1.Minus(complex2);
                        Console.WriteLine("Вычетание " + resultMinus.ToString());
                        Console.ReadKey();
                        break;
                    case "*":
                        Complex resultMulti = complex1.MultiCation(complex2);
                        Console.WriteLine("Умножение " + resultMulti.ToString());
                        break;
                    case "0":
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Такого задания нет...");
                        break;
                
                }
            }
            
           
            
            Console.ReadKey();

        }
    }

}