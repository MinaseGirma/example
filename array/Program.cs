namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[,] minase1 = new int[,]{
                 { 1, 2 },
                 { 3, 4 }
             };
             {
                 Console.WriteLine($"minase1[0,0]: {minase1[0, 0]}");
                 Console.WriteLine($"minase1[0,0]: {minase1[0, 1]}");
                 Console.WriteLine($"minase1[0,0]: {minase1[1, 1]}");
             }

             for (int i = 0; i < minase1.GetLength(0); i++)
             {

                 for (int j = 0; j < minase1.GetLength(1); j++)
                 {
                     Console.WriteLine(minase1[i, j]);
                 }

                 int[,]
                     minase2 = new int[4, 4]
                     {
                         { 1, 2, 3, 4 },
                         { 3, 4, 5, 6 },
                         { 5, 6, 7, 8 },
                         { 6, 7, 8, 9 },
                     };*/
            Console.WriteLine($"new solution: ");
                var arr1 = new int[4, 4]
{
                    {1,2,3,4 },
                    {5,6,7,8 },
                    {9,10,11, 12},
                    {11,12,13,14},
};
                int i;
                int j;

                for (i = 0; i < Math.Sqrt(arr1.Length); i++)
                {
                    for (j = 0; j < Math.Sqrt(arr1.Length); j++)
                    {
                        Console.WriteLine(arr1[i, j]);
                    }
                }
                
            }
        }
    }

