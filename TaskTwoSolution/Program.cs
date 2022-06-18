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
            //Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
            //Console.WriteLine(System.Environment.CurrentDirectory);
            //Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            //Console.WriteLine(Environment.CurrentDirectory);
            //Console.ReadLine();

            //Console.WriteLine("Hello World!");
            //WorkBook workBook = WorkBook.Load("warehouse.csv");
            //WorkSheet workSheet = workBook.DefaultWorkSheet;

            //workSheet.SetRepeatingRows(1, 8);
            //workSheet.SetRepeatingColumns(1, 26);
            //var csvFileReader = new DataTable();
            //csvFileReader = ReadExcel(warehouse);

            //Data data = new Data();
            Data.GetData();
            Console.WriteLine(Data.totalStockLeft("RI", "100448"));
        }
    }

    //private DataTable ReadExcel(string warehouse)
    //    {
    //        WorkBook workBook = WorkBook.Load(warehouse);
    //        WorkSheet workSheet = workBook.GetWorkSheet("warehouse.csv");
    //        //WorkSheet workSheet = workBook.DefaultWorkSheet;
    //        return workSheet.ToDataTable(true);
    //    }

    //    public void ReadCSVData(string warehouse)
    //    {
    //        var csvFileReader = new DataTable();
    //        csvFileReader = ReadExcel(warehouse);
    //        string columnData = csvFileReader.Columns[0].ToString();
    //        string rowData = csvFileReader.Rows[0].ToString();
    //    }

        
}

