using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.SortingAlgorithms
{
    public static class BucketSort
    {
        public static List<TShirt> BucketSortOrderBySize(this List<TShirt> shirts)
        {
            List<List<TShirt>> shirt = new List<List<TShirt>>();
            InitializeBuckets(shirt);
            Scatter(shirts, shirt);
            int i = 0;
            foreach (List<TShirt> bucket in shirt)
            {
                foreach (var s in bucket)
                {
                    shirts[i++] = s;
                }
            }
            return shirts;
        }
        private static void Scatter(List<TShirt> shirts, List<List<TShirt>> shirt)
        {
            foreach (var value in shirts)
            {
                int bucketNumber = GetBucketNumber(value);
                shirt[bucketNumber].Add(value);
            }
        }

        private static int GetBucketNumber(TShirt shirt)
        {
            int bucketNumber = ((int)shirt.Size);
            return bucketNumber;
        }
        private static void InitializeBuckets(List<List<TShirt>> buckets)
        {
            for (int i = 0; i < 10; i++)
            {
                List<TShirt> a = new List<TShirt>();
                buckets.Add(a);
            }
        }
    }
}
