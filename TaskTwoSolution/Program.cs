using IronXL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TaskTwoSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            Data.GetData();
            Console.WriteLine(Data.TotalStockLeft("RI", "100448"));
        }
    }
}

