using System;

namespace LoginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vanya ivan = new Vanya();
            ivan.ShowLoginDates();
            Misha misha = new Misha();
            misha.ShowLoginDates();
            Petya petya = new Petya();  
            petya.ShowLoginDates();
          
        }
    }
}
