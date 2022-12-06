using System;
namespace Essential.Class
{
    public class Converter
    {
        private double sum;
        private double currency;
        double usd, eur, pln;

        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }
        public void ConverterInCurrency()
        {
            Console.WriteLine("Виберіть цифру, відповідно валюті 1-usd 2-eur 3-pln");
            currency = Int32.Parse(Console.ReadLine());
            if (currency == 1)
            {
                GrnInUsd();
            }
            if (currency == 2)
            {
                GrnInEur();
            }
            if (currency == 3)
            {
                GrnInPln();
            }
            if (currency != 1 && currency != 2 && currency != 3)
            {
                Console.WriteLine("Введіть число, відповідно до валюти");
                ConverterInCurrency();
            }
        }
        public void ConverterInGrn()
        {
            Console.WriteLine("Виберіть цифру, відповідно валюті 1-usd 2-eur 3-pln");
            currency = Int32.Parse(Console.ReadLine());
            if (currency == 1)
            {
                UsdInGrn();
            }
            if (currency == 2)
            {
                EurInGrn();
            }
            if (currency == 3)
            {
                PlnInGrn();
            }
            if (currency != 1 && currency != 2 && currency != 3)
            {
                Console.WriteLine("Введіть число, відповідно до валюти");
                ConverterInCurrency();
            }
        }
        private void GrnInUsd()
        {
            Console.Write("Введіть суму гривні: ");
            sum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{sum / usd} usd");
        }
        private void GrnInEur()
        {
            Console.Write("Введіть суму гривні: ");
            sum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{sum / eur} eur");
        }
        private void GrnInPln()
        {
            Console.Write("Введіть суму гривні: ");
            sum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{sum / pln} pln");
        }
        private void UsdInGrn()
        {
            Console.Write("Введіть суму Usd: ");
            sum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{sum * usd} grn");
        }
        private void EurInGrn()
        {
            Console.Write("Введіть суму Eur: ");
            sum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{sum * eur} grn");
        }
        private void PlnInGrn()
        {
            Console.Write("Введіть суму Pln: ");
            sum = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{sum * pln} grn");
        }
    }
}
