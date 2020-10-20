using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 3;
            int end = 7;
            int[] routeNumbers = GetRouteNumbers(start, end);
            Console.WriteLine("Route numbers to move from " + start + " to " + end + "\n");

            foreach (int rote in routeNumbers)
            {
                Console.Write(rote + "\t");
            }
            Console.ReadLine();
        }
        public static int[] GetRouteNumbers(int start, int end)
        {
            FindShortestPath find = new FindShortestPath();
            List<int[]> allPaths = find.GetShortestPathList(Data.Graph, Data.Vertices, start);
            int[] path = allPaths[end];
            List<int> routeNumbers = new List<int>();

            for (int j = 0; j < path.Length - 1; j++)
            {
                for (int i = 0; i < Data.Endpoints.GetLength(0); i++)
                {
                    if ((Data.Endpoints[i, 0] == path[j] && Data.Endpoints[i, 1] == path[j + 1]) ||
                        (Data.Endpoints[i, 1] == path[j] && Data.Endpoints[i, 0] == path[j + 1]))
                    {
                        routeNumbers.Add(i);
                        break;
                    }
                }
            }
            return routeNumbers.ToArray();
        }
    }
}
