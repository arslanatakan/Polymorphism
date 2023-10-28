using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //overloading - polymorphism gibi
            MathHelper mathHelper = new MathHelper();
            //Aynı isimde bir base class var içinde konusma() metodu var.
            //kopek adında bir class ımız daha var ama bu metod onda da var.

            MathHelper myDog = new Dog();

            mathHelper.Sound();
            myDog.Sound();

            //virtual => türetilmiş (derived) bir class var ise bu virtual metodunu OVERRIDE edebilir.
            //bu sayede son kullanıcı kendine has özellikleri bu metoda aktarabilir.
            //hayvan sınıfında sound() = hayvan sesi iken
            //dog sınıfında sound() = havhav oldu. (override ettik.)





            Console.ReadLine();
        }
    }
}
