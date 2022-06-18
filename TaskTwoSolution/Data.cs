using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TaskTwoSolution
{
    public static class Data
    {
        public static List<SKU> SkuData { get; set; } = new List<SKU>();
        public static void GetData()
        {
            var baseDir = Directory.GetCurrentDirectory();
            var url = Path.Combine(baseDir, "../../../warehouses-with-skus.csv");
            using StreamReader sr = new StreamReader(url);
            using StreamReader state = new StreamReader(Path.Combine(baseDir, "../../../warehouses.csv"));

            string line;
            List<string> row = new List<string>();
            List<State> stateData = new List<State>();

            var header = sr.ReadLine().Split(',').ToList();
            var stateHeader = state.ReadLine().Split(',').ToList();
            header.RemoveAt(0);
            stateHeader.ForEach(x => stateData.Add(new
                State
            { Id = x, States = new List<string>() }));

            while ((line = state.ReadLine()) != null)
            {
                row = line.Split(',').ToList();
                for (int i = 0; i < stateData.Count; i++)
                {
                    stateData[i].States.Add(row[i]);
                }
            }

            while ((line = sr.ReadLine()) != null)
            {
                row = line.Split(',').ToList();
                List<Warehouse> listOfWarehouses = new List<Warehouse>();
                int rowNum = 1;
                foreach (var data in header)
                {
                    int id = 0;
                    int.TryParse(data, out id);
                    listOfWarehouses.Add(new Warehouse
                    {

                        Id = id,
                        StockLeft = int.Parse(row[rowNum]),
                        State = stateData.First(x => x.Id == data).States
                    });
                    rowNum++;
                }
                
                SkuData.Add(new SKU
                {
                    SkuId = row[0],
                    Warehouses = listOfWarehouses
                });
            }
        }
        public static long TotalStockLeft(string state, string Sku)
        {
            var getSku = SkuData.FirstOrDefault(x => x.SkuId == Sku);
            if (getSku != null)
            {
                var data = getSku.Warehouses.Where(x => x.State.Contains(state)).Sum(x => x.StockLeft);
                return data;
            }
            return 0;
        }
    }
}
