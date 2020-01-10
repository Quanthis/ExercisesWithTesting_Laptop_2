using System;
using Xunit;
using KalkulatorBiblioteka;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double a = 2;
            double b = 2;
            double oczekiwane = 4;
            var kal = new Kalkulator();
            double wynik = kal.Dodaj(a, b);
            Assert.Equal(oczekiwane, wynik);
        }
        [Fact]
        public void Test2()
        {
            double a = 2;
            double b = 3;
            double oczekiwane = 5;
            var kal = new Kalkulator();
            double wynik = kal.Dodaj(a, b);
            Assert.Equal(oczekiwane, wynik);
        }
    }
}
