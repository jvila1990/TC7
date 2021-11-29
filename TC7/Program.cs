using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el grafo 1
            int[,] graph3 = {
                { 0, 8, 0, 0, 0, 0, 0},
                { 6, 0, 16, 0, 0, 0, 0},
                { 0, 0, 0, 10, 8, 9, 0},
                { 0, 0, 1, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 10, 0},
                { 0, 0, 0, 0, 5, 0, 6},
                { 5, 8, 0, 0, 0, 0, 0}
            };

            //El camino más corto de Dijkstra
            Dijkstra.DijkstraAlgo(graph3, 0, 7);

            Console.WriteLine("");


            //Console.Read();

            int[,] graph = {
               { 0, 8, 0, 0, 0, 0, 0},
                { 6, 0, 16, 0, 0, 0, 0},
                { 0, 0, 0, 10, 8, 9, 0},
                { 0, 0, 1, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 10, 0},
                { 0, 0, 0, 0, 5, 0, 6},
                { 5, 8, 0, 0, 0, 0, 0}
            };

            Prim.PrimAlgo(graph, 7);

            Console.Read();
        }
    }
}
