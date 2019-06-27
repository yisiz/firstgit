using System;

namespace Labyrinth
{
    class Program
    {
        /*//global variable maze
            global start position      
           
        //function(currentposition {x,y})
        //{ compare currentposition  with the maze;
        //  exit { if {x,y} in maze is "e" } print all v!!
            else:
        //  if({x-1,y} == " ") move .. 4x
        //  if (true) make{x,y} "v" + run function again
            if (false) 4x -> how to identify where is the v?? done-write at the end + return
            if (out of maze) -> return
        */

        static char[,] lab =
        {
          {' ', ' ', ' ', '*', ' ', ' ', ' '},
          {'*', '*', ' ', '*', ' ', '*', ' '},
          {' ', ' ', ' ', ' ', ' ', ' ', ' '},
          {' ', '*', '*', '*', '*', '*', ' '},
          {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };
        static int[] startPosition = new int[] { 0, 0 };

        static void solveLabyrinth(int[] currentposition)
        {
            if (lab[currentposition[0], currentposition[1]] == 'e')
            {
                //print the maze
                PrintMaze();
            }
            else
            {   
                if(currentposition[0] - 1 >= 0) {
                    char temp = lab[currentposition[0] - 1, currentposition[1]];
                    if ( temp  == ' ' || temp == 'e')
                    {
             
                        lab[currentposition[0], currentposition[1]] = 'v';
                        //PrintMaze();
                        solveLabyrinth( new int[] {currentposition[0]-1,currentposition[1]} );
                        lab[currentposition[0], currentposition[1]] = ' ';
                    }
                }

                if (currentposition[1] + 1 < lab.GetLength(1) )
                {
                    char temp = lab[currentposition[0], currentposition[1] + 1];
                    if (temp == ' ' || temp == 'e')
                    {
                      
                        lab[currentposition[0], currentposition[1]] = 'v';
                        //PrintMaze();
                        solveLabyrinth(new int[] { currentposition[0], currentposition[1]+1 });
                        lab[currentposition[0], currentposition[1]] = ' ';

                    }
                }

                if (currentposition[0] + 1 < lab.GetLength(0) )
                {
                    char temp = lab[currentposition[0] + 1, currentposition[1]];
                    if (temp == ' ' || temp == 'e')
                    {
                     
                        lab[currentposition[0], currentposition[1]] = 'v';
                        //PrintMaze();
                        solveLabyrinth(new int[] { currentposition[0] +1, currentposition[1] });
                        lab[currentposition[0], currentposition[1]] = ' ';
                    }
                }

                if (currentposition[1] - 1 >= 0)
                {
                    char temp = lab[currentposition[0], currentposition[1] - 1];
                    if (temp == ' ' || temp == 'e')
                    {
                      
                        lab[currentposition[0], currentposition[1]] = 'v';
                        //PrintMaze();
                        solveLabyrinth(new int[] { currentposition[0] , currentposition[1] -1 });
                        lab[currentposition[0], currentposition[1]] = ' ';
                    }
                }
                //  if({x-1,y} == " ") move .. 4x
                //  if (true) make{x,y} "v" + run function again
                //if (false) 4x->how to identify where is the v ?? done - write at the end + return
                //if (out of maze) -> return

            }
        }

        static void Main(string[] args)
        {
            //maze
            //call function
            solveLabyrinth(startPosition);
        }

        static void PrintMaze()
        {
            for (int row = 0; row < lab.GetLength(0); row++)
            {
                for (int col = 0; col < lab.GetLength(1); col++)
                {
                    Console.Write(lab[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
