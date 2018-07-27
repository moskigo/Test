using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace AutoStop.Models
{
    public static class TestData
    {


        public static List<Part> GetParts()
        {
            List<Part> list = new List<Part>();
            list.Add(new Part() { id = 1, Number = "12JJJ", Description = "Tjklkd sdfsdfjskjdf sdfsdfsf", Qty = 12, Price = 234, Qty1 = 12, Qty2 = 14, Brand = "LPA" });
            list.Add(new Part() { id = 2, Number = "14KKO", Description = "Sokkok sdfsdfjskjdf sdfsdfsf", Qty = 15, Price = 290, Qty1 = 11, Qty2 = 17, Brand = "BGT" });
            list.Add(new Part() { id = 3, Number = "15KKO", Description = "Weerytty sdfsdfjskjdf sdfsdfsf", Qty = 23, Price = 800, Qty1 = 16, Qty2 = 11, Brand = "RTY" });
            list.Add(new Part() { id = 4, Number = "11OOO", Description = "Sailent blok nadezniy", Qty = 30, Price = 750, Qty1 = 17, Qty2 = 11, Brand = "RTY" });

            return list;

        }

        public static List<Part> GetAnalog(int id)
        {
            List<Analog> analog = new List<Analog>();
            analog.Add(new Analog() { partId = 1, analogId = 2 });
            analog.Add(new Analog() { partId = 2, analogId = 1 });
            analog.Add(new Analog() { partId = 1, analogId = 3 });
            analog.Add(new Analog() { partId = 4, analogId = 3 });
            analog.Add(new Analog() { partId = 3, analogId = 4 });

            var an = analog.Where(a => a.partId == id).ToList();

            var res = from part in GetParts()
                      join a in an on part.id equals a.analogId
                      select part;

            return res.ToList();
            
        }

        public static List<Part> GetByString(string str)
        {
            Regex regex = new Regex(str+@"(\w*)", RegexOptions.IgnoreCase);
            var filtered = GetParts().Where(a => regex.Matches(a.Description).Count > 0);

            return filtered.ToList();
        }
    }
}