using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void BubbleSortOrderBySize(this List<TShirt> shirts)
        {
            TShirt t;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Size > shirts[i + 1].Size)
                    {
                        t = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = t;
                    }
                }
            }

        }
        public static void BubbleSortOrderByDescendingSize(this List<TShirt> shirts)
        {
            TShirt t;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Size < shirts[i + 1].Size)
                    {
                        t = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = t;
                    }
                }
            }

        }
        public static void BubbleSortOrderBySizeColorFabric(this List<TShirt> shirts)
        {
            TShirt t;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Fabric > shirts[i + 1].Fabric)
                    {
                        t = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = t;
                    }
                    if (shirts[i].Color > shirts[i + 1].Color)
                    {
                        t = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = t;
                    }
                    if (shirts[i].Size > shirts[i + 1].Size)
                    {
                        t = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = t;
                    }
                }
            }

        }
        public static void BubbleSortOrderByDescendingSizeColorFabric(this List<TShirt> shirts)
        {
            TShirt t;
            for (int p = 0; p <= shirts.Count - 2; p++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Fabric < shirts[i + 1].Fabric)
                    {
                        t = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = t;
                    }
                    if (shirts[i].Color < shirts[i + 1].Color)
                    {
                        t = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = t;
                    }
                    if (shirts[i].Size < shirts[i + 1].Size)
                    {
                        t = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = t;
                    }
                }
            }

        }
    }
}
