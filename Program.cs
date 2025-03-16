using System;

namespace tpmod5_103022330059
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataGeneric<string> dataString = new DataGeneric<string>("Data pertama");
            dataString.PrintData();  

        
            DataGeneric<int> dataInt = new DataGeneric<int>(123);
            dataInt.PrintData();  
        }
    }
}