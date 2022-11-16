using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_textMap
{
    internal class Program
    {
        static char[,] map = new char[,]
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        static int mapHeight = map.GetLength(0);
        static int mapWidth = map.GetLength(1);

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            DisplayMap();
            Console.ReadKey(true);
            Console.Clear();

            displayMap(1);
            Console.ReadKey(true);
            Console.Clear();

            displayMap(2);
            Console.ReadKey(true);
            Console.Clear();

            displayMap(3);
            Console.ReadKey(true);

        }
        static void DisplayMap()
        {

            for (int mapX = 0; mapX < mapHeight; mapX++)
            {
                Console.SetCursorPosition(0, mapX);
                for (int mapY = 0; mapY < mapWidth; mapY++)
                {
                    Console.Write(map[mapX, mapY]);
                }
                Console.WriteLine();
                
            }
        }
        static void displayMap(int scale)
        {

            int mapV = 0;
            int drawV;

            int mapH = 0;

            int rowNum = 1;
            int colNum = 1;


            int mapRow = rowNum + 1;
            int mapCol = colNum + 1;

            int drawH = mapCol;

            for (int column = 0; column < mapHeight; column++)
            {
                for (int row = 0; row < mapWidth; row++)
                {
                    drawV = mapRow;
                    for (int v = 0; v < scale; v++)
                    {
                        char tile = (map[mapV, mapH]);

                        Console.SetCursorPosition(drawH, drawV);
                        for (int h = 0; h < scale; h++)
                        {

                            switch (tile)
                            {
                                case '^':
                                    Console.BackgroundColor = ConsoleColor.DarkGray;
                                    Console.Write(tile);
                                    break;

                                case '`':
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.Write(tile);
                                    break;

                                case '~':
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.Write(tile);
                                    break;

                                case '*':
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(tile);
                                    break;

                                default:
                                    Console.Write(tile);
                                    break;

                            }

                            Console.ResetColor();
                        }
                        drawV = drawV + 1;
                    }
                    mapH = mapH + 1;
                    drawH = drawH + scale;


                }
                mapRow = mapRow + scale;
                drawH = mapCol;

                mapV = mapV + 1;
                mapH = 0;
            }

            Console.SetCursorPosition(colNum, rowNum);


        }
    }
}
