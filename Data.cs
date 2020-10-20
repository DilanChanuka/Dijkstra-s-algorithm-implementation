using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_algorithm
{
    public static class Data
    {
        #region PreDefined DataSet

        public static int Vertices = 9;
        
        public static int[,] Endpoints = new int[,]
        {
            {0,1 },{1,2 },{2,3 },{3,4 },{ 4,5},{5,6 },{6,7 },{0,7 },{1,7 },{ 7,8},{ 6,8},{2,8 },{2,5 },{ 3,5}
        };    

        public static int[,] Graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
        
        #endregion
    }
}
