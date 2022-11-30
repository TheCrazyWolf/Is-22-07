using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Controller
    {
        public static List<Good> Goods = new List<Good>();

        public void AddGood(string title, float price, float sale, string desc)
        {
            Good good = new Good()
            {
                Title = title,
                Price = price,
                Sale = sale,
                Description = desc
            };

            Goods.Add(good);
        }

        public string GetGoods()
        {
            string text = "";

            foreach (var item in Goods)
            {
                text += $"{item.Title} цена - {item.Price}\n";
            }

            return text;
        }
    }
}
