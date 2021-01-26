using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            
            myDictionary.Add(1, "Adana");
            myDictionary.Add(2, "Adıyaman");
        }
    }
}
