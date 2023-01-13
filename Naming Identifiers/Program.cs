using System;

namespace Naming_Identifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
        }
    }

    public class Numbers
    {
        const int MaxCount = 6;
        class InnerClasNumbers
        {
            internal void Print(bool variable)
            {
                string variableAsString = variable.ToString();
                Console.WriteLine(variableAsString);
            }
        }
        public void Entrance()
        {
            InnerClasNumbers instance = new InnerClasNumbers();

            instance.Print(true);
        }
    }
}
