using System;
using Barcode.BL;
using System.Collections.Generic;

namespace Barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // item category --> 3
            // item price ----> 5
            // item number ---> 5

            string Barcodes = @"0010020000001-0020050000002-0030099900003-0040010000004";
            string[] barcodesArray = Barcodes.Split('-');

            Item OItem = new Item();

            List<Item> LstItems = new List<Item>();
            foreach (string barcode in barcodesArray)
            {
                OItem = new Item();
                OItem.CategoryNumber = Convert.ToInt32(barcode.Substring(0, 3));
                OItem.ItemPrice = Convert.ToInt32(barcode.Substring(3, 5));
                OItem.ItemNumber = Convert.ToInt32(barcode.Substring(8, 5));
                Console.WriteLine("Enter item name");
                OItem.ItemName = Console.ReadLine();
                LstItems.Add(OItem);
            }

            string NewBarCode = string.Empty;
            Item myItem = new Item();
            foreach (var item in LstItems)
            {
                NewBarCode += $"-{myItem.GetFormatedCategoryNumber(item.CategoryNumber)}{myItem.GetFormatedItemPrice(item.ItemPrice)}{myItem.GetFormatedItemNumber(item.ItemNumber)}";
            }
            Console.WriteLine(NewBarCode);
        }
    }
}
