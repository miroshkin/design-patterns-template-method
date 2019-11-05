using System;

namespace DesignPatterns_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns - Template Method");

            McDonaldsBurger burgerOne = new McDonaldsBurger();
            KFCBurger burgerTwo = new KFCBurger();

            Console.WriteLine($"Burger One Price ({burgerOne.GetType()}) is {burgerOne.GetBurgerPrice()}");
            Console.WriteLine($"Burger Two Price ({burgerTwo.GetType()})is {burgerTwo.GetBurgerPrice()}");
        }
    }

    public abstract class PriceCalculator
    {
        //Template method
        public decimal GetBurgerPrice()
        {
            var bread = GetBreadPrice();
            var meat = GetMeatPrice();
            var salad = GetSaladPrice();

            return bread + meat + salad;
        }

        private decimal GetBreadPrice()
        {
            return 10;
        }

        public abstract decimal GetMeatPrice();

        public abstract decimal GetSaladPrice();

    }

    public class McDonaldsBurger : PriceCalculator
    {
        public override decimal GetMeatPrice()
        {
            return 30;
        }

        public override decimal GetSaladPrice()
        {
            return 20;
        }
    }

    public class KFCBurger : PriceCalculator
    {
        public override decimal GetMeatPrice()
        {
            return 40;
        }

        public override decimal GetSaladPrice()
        {
            return 20;
        }
    }

}
