using System;

namespace rebaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Getlimit(string name)
        {
            return name.Length;
        }

        public int GetlimitEx(string name)
        {
            return name.Length * 2;
        }

    }

    public enum SalesTax
    {
        ThirteenPercent = 0,
        FiftheenPercent = 1,
        SixteePercent = 2
    }

    public enum SalesTaxFromFeature
    {
        ThirteenPercent = 0,
        FiftheenPercent = 1,
        SixteePercent = 2
    }

    public struct NameOnly
    {
        public string structName { get; set; }
    }

    public struct RebaseTest{
        public string DataName;
    }

    public struct NameOnlyEx
    {
        public string structName { get; set; }
    }

    public struct RebaseTestEx{
        public string DataName;
    }
}



