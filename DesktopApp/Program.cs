using DesktopApp.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            //var shirts=db.TShirts.OrderBy(x=>x.Fabric).ThenBy(x=>x.Color).ThenBy(x=>x.Size);

            var shirts = db.TShirts;

            //Bubble Sort
            // BubbleSort.BubbleSortOrderBySize(shirts);
            shirts.BubbleSortOrderBySize();
            shirts.BubbleSortOrderByDescendingSize();
            shirts.BubbleSortOrderBySizeColorFabric();
            shirts.BubbleSortOrderByDescendingSizeColorFabric();

            //Quick Sort
            //QuickSort.QuickSortOrderByColor(shirts, 0, shirts.Count - 1);
            shirts.QuickSortOrderByColor(0, shirts.Count - 1);

            //Bucket Sort
            shirts.BucketSortOrderBySize();
            shirts.BucketSortOrderByFabric();
            shirts.BucketSortOrderByColor();

            //Print Sorted List of Tshirts
            foreach (var shirt in shirts)
            {
                shirt.Output();
            }
        }
    }
}
