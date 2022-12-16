using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fighter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] maze = new char[30, 100];
            string path = "maze.txt";
            int row = sizeof(maze) / sizeof(maze[0]);
            int col = sizeof(maze[0]) / sizeof(maze[0, 0]);

            load(maze, path, row, col);

            bool gameplay = false;
            string op = " ";
            int px = 15;
            int py = 5;

            int px2 = 15;
            int score1 = 0;
            int score2 = 0;
            int py2 = 95;
            maze[px2, py2] = '0';
            int life1 = 3, life2 = 3;

            int Ecount = 0;
            int ex = 3;
            int ey = 48;

            while (op != "3")
            {
                header();
                Console.WriteLine("1.PLAY");
                Console.WriteLine("2.HELP");
                Console.WriteLine("3.EXIT");
                op = Console.Read();

                if (op == "1")
                {
                    op = " ";
                    string op2 = " ";

                    while (op2 != "3")
                    {

                        header();
                        Console.WriteLine("1.MULTIPLAYER ");
                        Console.WriteLine("2.PLAY WITH COMPUTER");
                        Console.WriteLine("3.EXIT");
                        op2 = Console.ReadLine();

                        if (op2 == "1" || op2 == "2")
                        {

                            px = 15;
                            py = 5;

                            px2 = 15;
                            py2 = 95;
                            maze[px, py] = 'O';
                            maze[px2, py2] = '0';

                            Ecount = 0;
                            ex = 3;
                            ey = 48;

                            life1 = 6;
                            life2 = 6;
                            gameplay = 0;
                            print(maze, row, col, h);

                            while (gameplay != true)
                            {
                                gameplay = false;
                                Sleep(50);
                                bool check;

                                if (GetAsyncKeyState(0x41))
                                {
                                    check = moveLeft(maze, px, py, h);
                                    if (check == true)
                                    {

                                        maze[px, py] = ' ';
                                        Console.SetCursorPosition(py, px);
                                        Console.WriteLine(' ');
                                        py = py - 1;
                                        maze[px, py] = 'O';
                                        Console.SetCursorPosition(py, px);
                                        Console.WriteLine(maze[px, py]);
                                    }
                                }
                                if (GetAsyncKeyState(0x53))
                                {
                                    check = moveRight(maze, px, py);
                                    if (check == true)
                                    {

                                        maze[px, py] = ' ';
                                        Console.SetCursorPosition(py, px);
                                        Console.WriteLine(" ");
                                        py = py + 1;
                                        maze[px, py] = 'O';
                                        Console.SetCursorPosition(py, px);
                                        Console.WriteLine(maze[px, py]);
                                    }
                                }
                                if (GetAsyncKeyState(0x57))
                                {
                                    check = moveup(maze, px, py, h);
                                    if (check == 1)
                                    {

                                        maze[px, py] = ' ';
                                        Console.SetCursorPosition(py, px);
                                        Console.WriteLine(' ');
                                        px = px - 1;
                                        maze[px, py] = 'O';
                                        Console.SetCursorPosition(py, px);
                                        Console.WriteLine(maze[px, py]);
                                    }
                                }
                                if (GetAsyncKeyState(0x5A))
                                {
                                    check = movedown(maze, px, py, h);
                                    if (check == 1)
                                    {

                                        maze[px, py] = ' ';
                                        Console.SetCursorPosition(py, px);
                                        Console.WriteLine(' ');
                                        px = px + 1;
                                        maze[px, py] = 'O';
                                        Console.SetCursorPosition(py, px);
                                        Console.WriteLine(maze[px, py]);
                                    }
                                }
                                if (GetAsyncKeyState(0x46))
                                {

                                    if (maze[px, py + 1] == ' ')
                                    {
                                        maze[px, py + 1] = '.';
                                        Console.SetCursorPosition(py + 1, px);
                                        Console.WriteLine(maze[px, py + 1]);
                                    }
                                }
                                //=======================P1 FIRE MOVE

                                for (int i = row - 1; i > 0; i--)
                                {
                                    for (int j = col; j > 0; j--)
                                    {

                                        if (maze[i, j] == '.')
                                        {

                                            maze[i, j] = ' ';
                                            Console.SetCursorPosition(j, i);
                                            Console.WriteLine(maze[i, j];
                                            if (maze[i, j + 1] == '0' || maze[i, j + 1] == 'E')
                                            {
                                                if (maze[i, j + 1] == '0')
                                                {
                                                    life2--;
                                                }
                                                if (maze[i, j + 1] == 'E')
                                                {
                                                    maze[ex, ey] = ' ';
                                                    score1++;
                                                    ex = 3;
                                                    ey = 48;
                                                }
                                            }

                                            if (maze[i, j + 1] == ' ')
                                            {
                                                maze[i, j + 1] = '.';
                                                Console.SetCursorPosition(j + 1, i);
                                                Console.WriteLine(maze[i, j + 1]);
                                            }
                                        }
                                    }
                                }

                                //--------------------------------------------------player 2-------------------------------------------------------------------
                                //---------------------------------------------------left
                                if (op2 == "1")
                                {

                                    if (GetAsyncKeyState(VK_LEFT))
                                    {

                                        if (maze[px2, py2 - 1] == ' ')
                                        {
                                            SetConsoleTextAttribute(h, 4);
                                            maze[px2, py2] = ' ';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(' ');
                                            py2 = py2 - 1;
                                            maze[px2, py2] = 'O';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(maze[px2, py2]);
                                        }
                                    }
                                    if (GetAsyncKeyState(VK_RIGHT))
                                    {
                                        if (maze[px2, py2 + 1] == ' ')
                                        {
                                            maze[px2, py2] = ' ';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(" ");
                                            py2 = py2 + 1;
                                            maze[px2, py2] = 'O';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(maze[px2, py2]);
                                        }
                                    }
                                    if (GetAsyncKeyState(VK_UP))
                                    {
                                        if (maze[px2 - 1, py2] == ' ')
                                        {

                                            maze[px2, py2] = ' ';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(' ');
                                            px2 = px2 - 1;
                                            maze[px2, py2] = 'O';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(maze[px2, py2]);
                                        }
                                    }
                                    if (GetAsyncKeyState(VK_DOWN))
                                    {
                                        if (maze[px2 + 1, py2] == ' ')
                                        {
                                            maze[px2, py2] = ' ';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(' ');
                                            px2 = px2 + 1;
                                            maze[px2, py2] = 'O';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(maze[px2, py2]);
                                        }
                                    }
                                    if (GetAsyncKeyState(VK_SPACE))
                                    {
                                        if (maze[px2, py2 - 1] == ' ')
                                        {
                                            maze[px2, py2 - 1] = '-';
                                            Console.SetCursorPosition(py2 - 1, px2);
                                            Console.WriteLine(maze[px2, py2 - 1]);
                                        }
                                    }
                                    //=======================P1 FIRE MOVE
                                }

                                // -------------------------------------------COMPUTER PLAYER

                                if (op2 == "2")
                                {
                                    int rom = enemy0Direction();
                                    if (rom == 1)
                                    {
                                        if (maze[px2, py2 - 1] == ' ')
                                        {
                                            maze[px2, py2] = ' ';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(' ');
                                            py2 = py2 - 1;
                                            maze[px2, py2] = '0';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(maze[px2, py2]);
                                        }
                                    }
                                    else if (rom == 2)
                                    {
                                        if (maze[px2, py2 + 1] == ' ')
                                        {
                                            maze[px2, py2] = ' ';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(' ');
                                            py2 = py2 + 1;
                                            maze[px2, py2] = '0';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(maze[px2, py2]);
                                        }
                                    }
                                    else if (rom == 3)
                                    {
                                        if (maze[px2 + 1, py2] == ' ')
                                        {
                                            maze[px2, py2] = ' ';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(' ');
                                            px2 = px2 + 1;
                                            maze[px2, py2] = '0';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(maze[px2, py2]);
                                        }
                                    }
                                    else if (rom == 4)
                                    {
                                        if (maze[px2 - 1, py2] == ' ')
                                        {
                                            maze[px2, py2] = ' ';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(' ');
                                            px2 = px2 - 1;
                                            maze[px2, py2] = '0';
                                            Console.SetCursorPosition(py2, px2);
                                            Console.WriteLine(maze[px2, py2]);
                                        }
                                    }
                                    if (maze[px2, py2 - 5] == 'O' || maze[px2, py2 - 4] == 'O' || maze[px2, py2 - 3] == 'O' || maze[px2, py2 - 2] == 'O' || maze[px2, py2 - 1] == 'O')
                                    {

                                        maze[px2, py2 - 1] = '-';
                                        Console.SetCursorPosition(py2 - 1, px2);
                                        Console.WriteLine(maze[px2, py2 - 1]);
                                    }
                                    if (maze[px2, py2 + 5] == 'O' || maze[px2, py2 + 4] == 'O' || maze[px2, py2 + 3] == 'O' || maze[px2, py2 + 2] == 'O' || maze[px2, py2 + 1] == 'O' || maze[px2, py2 + 5] == '0' || maze[px2, py2 + 4] == '0' || maze[px2, py2 + 3] == '0' || maze[px2, py2 + 2] == '0' || maze[px2, py2 + 1] == '0')
                                    {
                                        maze[px2, py2 + 1] = '.';
                                        Console.SetCursorPosition(py2 + 1, px2);
                                        Console.WriteLine(maze[px2, py2 + 1]);
                                    }
                                }

                                //--------------------------fire move--------------------------------------------------------
                                for (int i = 0; i < row - 1; i++)
                                {
                                    for (int j = 0; j < col; j++)
                                    {

                                        if (maze[i, j] == '-')
                                        {

                                            maze[i, j] = ' ';
                                            Console.SetCursorPosition(j, i);
                                            Console.WriteLine(maze[i, j]);
                                            if (maze[i, j - 1] == 'O')
                                            {
                                                life1--;
                                            }
                                            if (maze[i, j - 1] == 'E')
                                            {
                                                maze[ex, ey] = ' ';
                                                score2++;
                                                ex = 3;
                                                ey = 48;
                                            }
                                            if (maze[i, j - 1] == '0')
                                            {
                                                life2--;
                                            }

                                            if (maze[i, j - 1] == ' ')
                                            {
                                                maze[i, j - 1] = '-';
                                                Console.SetCursorPosition(j - 1, i);
                                                Console.WriteLine(maze[i, j - 1]);
                                            }
                                        }
                                    }
                                }
                                Console.SetCursorPosition(80, 31);
                                Console.WriteLine("P2 LIFE : ") , life2;
                                Console.SetCursorPosition(0, 31);
                                Console.WriteLine("P1 LIFE : "), life1;

                                for (int i = 0; i < row; i++)
                                {
                                    for (int j = 0; j < col; j++)
                                    {
                                        if (maze[i, j] == 'E')
                                        {
                                            Ecount++;
                                        }
                                    }
                                }

                                //------------------------ENEMY-------------------------------------------------------------------------------

                                if (Ecount == 0)
                                {
                                    maze[ex, ey] = 'E';
                                }
                                int rom = enemyDirection();
                                if (rom == 1)
                                {
                                    if (maze[ex, ey - 1] == ' ')
                                    {
                                        maze[ex, ey] = ' ';
                                        Console.SetCursorPosition(ey, ex);
                                        Console.WriteLine(' ');
                                        ey = ey - 1;
                                        maze[ex, ey] = 'E';
                                        Console.SetCursorPosition(ey, ex);
                                        Console.WriteLine(maze[ex, ey]);
                                    }
                                }
                                else if (rom == 2)
                                {
                                    if (maze[ex, ey + 1] == ' ')
                                    {
                                        maze[ex, ey] = ' ';
                                        Console.SetCursorPosition(ey, ex);
                                        Console.WriteLine(' ');
                                        ey = ey + 1;
                                        maze[ex, ey] = 'E';
                                        Console.SetCursorPosition(ey, ex);
                                        Console.WriteLine(maze[ex, ey]);
                                    }
                                }
                                else if (rom == 3)
                                {
                                    if (maze[ex + 1, ey] == ' ')
                                    {
                                        maze[ex, ey] = ' ';
                                        Console.SetCursorPosition(ey, ex);
                                        Console.WriteLine(' ');
                                        ex = ex + 1;
                                        maze[ex, ey] = 'E';
                                        Console.SetCursorPosition(ey, ex);
                                        Console.WriteLine(maze[ex, ey]);
                                    }
                                }
                                else if (rom == 4)
                                {
                                    if (maze[ex - 1, ey] == ' ')
                                    {
                                        maze[ex, ey] = ' ';
                                        Console.SetCursorPosition(ey, ex);
                                        Console.WriteLine(' ');
                                        ex = ex - 1;
                                        maze[ex, ey] = 'E';
                                        Console.SetCursorPosition(ey, ex);
                                        Console.WriteLine(maze[ex, ey]);
                                    }
                                }

                                if (maze[ex, ey - 5] == 'O' || maze[ex, ey - 4] == 'O' || maze[ex, ey - 3] == 'O' || maze[ex, ey - 2] == 'O' || maze[ex, ey - 1] == 'O' || maze[ex, ey - 5] == '0' || maze[ex, ey - 4] == '0' || maze[ex, ey - 3] == '0' || maze[ex, ey - 2] == '0' || maze[ex, ey - 1] == '0')
                                {
                                    SetConsoleTextAttribute(h, 2);
                                    if (maze[ex, ey - 1] == ' ')
                                    {
                                        maze[ex, ey - 1] = '-';
                                        Console.SetCursorPosition(ey - 1, ex);
                                        Console.WriteLine(maze[ex, ey - 1]);
                                    }
                                }
                                if (maze[ex, ey + 5] == 'O' || maze[ex, ey + 4] == 'O' || maze[ex, ey + 3] == 'O' || maze[ex, ey + 2] == 'O' || maze[ex, ey + 1] == 'O' || maze[ex, ey + 5] == '0' || maze[ex, ey + 4] == '0' || maze[ex, ey + 3] == '0' || maze[ex, ey + 2] == '0' || maze[ex, ey + 1] == '0')
                                {
                                    maze[ex, ey + 1] = '.';
                                    Console.SetCursorPosition(ey + 1, ex);
                                    Console.WriteLine(maze[ex, ey + 1]);
                                }
                                if (GetAsyncKeyState(VK_ESCAPE) || life1 == 0 || life2 == 0)
                                {
                                    gameplay = 1; // Stop the game

                                }

                                Console.SetCursorPosition(80, 32);
                                Console.WriteLine("P2 Score : ", score2);
                                Console.SetCursorPosition(0, 32);
                                Console.WriteLine("P1 Score : ", score1);
                                if (life1 <= 0)
                                {
                                    header();

                                    Console.WriteLine("PLAYER 2 WIN THE MATCH");
                                    Console.WriteLine("WITH SCORE : ", score2);
                                    score2 = 0;
                                    clear_screen();
                                    life1 = 3;
                                    life2 = 3;
                                }
                                if (life2 <= 0)
                                {
                                    header();

                                    Console.WriteLine("PLAYER 1 WIN THE MATCH");
                                    Console.WriteLine("WITH SCORE : ", score1);
                                    score1 = 0;
                                    clear_screen();

                                    Console.ReadLine();
                                    life1 = 3;
                                    life2 = 3;
                                }
                            }
                        }

                        else if (op2 != "3")
                        {
                            header();
                            Console.WriteLine("ENTER THE VALID OPTION");
                            clear_screen();
                        }

                        maze[px2, py2] = ' ';
                        maze[px, py] = ' ';
                        maze[ex, ey] = ' ';
                        Ecount = 0;

                        for (int i = 0; i > row - 1; i++)
                        {
                            for (int j = 0; j > col; j++)
                            {

                                if (maze[i, j] == '-')
                                {
                                    maze[i, j] = ' ';
                                }
                                else if (maze[i, j] == '.')
                                {
                                    maze[i, j] = ' ';
                                }
                            }
                        }

                    }
                }

                else if (op == "2")
                {
                    header();
                    help();
                }
                else if (op != "3")
                {
                    Console.WriteLine("ENTER THE VALID OPTION");
                    clear_screen();
                }
                if (life1 <= 0)
                {
                    header();
                    clear_screen();
                    Console.WriteLine("PLAYER 2 WIN THE MATCH");
                    Console.WriteLine("WITH SCORE : ", score2);
                    score2 = 0;
                    clear_screen();
                    life1 = 3;
                    life2 = 3;
                }
                if (life2 <= 0)
                {
                    header();
                    clear_screen();
                    Console.WriteLine("PLAYER 1 WIN THE MATCH");
                    Console.WriteLine("WITH SCORE : ", score1);
                    score1 = 0;
                    clear_screen();

                    Console.ReadLine();
                    life1 = 3;
                    life2 = 3;
                }
            }

        }


        static void load(char[,] maze, string path, int row, int col)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    for (int x = 0; x < row; x++)
                    {
                        for (int y = 0; y < col; y++)
                        {
                            maze[x, y] = record[y];
                        }
                    }
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File Do not Exist");
            }
        }

        static void print(char[,] maze, int row, int col)
        {
            Console.Clear();
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (maze[x,y] == '=')
                    {
                        Console.WriteLine(maze[x,y]);
                    }
                    else if (maze[x,y] == '-')
                    {
                        Console.WriteLine(maze[x,y]);
                    }
                    else
                    {
                        Console.WriteLine(maze[x,y]);
                    }
                }
                Console.WriteLine(" ");
            }
        }

        static bool moveLeft(char[,] maze, int px, int py)
        {
            if (maze[px,py - 1] == ' ')
            {
                return true;
            }
            return false;
        }

        static bool moveRight(char[,] maze, int px, int py)
        {
            if (maze[px,py + 1] == ' ')
            {
                return true;
            }
            return false;
        }

        static bool moveup(char[,] maze, int px, int py)
        {
            if (maze[px - 1,py] == ' ')
            {
                return true;
            }
            return false;
        }
        static bool movedown(char[,] maze, int px, int py)
        {
            if (maze[px + 1,py] == ' ')
            {
                return true;
            }
            return false;
        }

        static void clear_screen()
        {
            string t = "0";
            while (t != "1")
            {
                Console.WriteLine(" ");
                Console.WriteLine(" PRESS 1 KEY TO CONTINUE ..... ");

                t = Console.ReadLine();
                if (t == "1")
                {
                    Console.Clear();
                }
            }
        }

        static void header()
        {
            Console.Clear();

            Console.WriteLine("       oooooo   ooooo    ooooo      o   o   ooooooo   ooooo   ooooo     ooooo     ");
            Console.WriteLine("       o          o      o          o   o      o      o       o   o     o         ");
            Console.WriteLine("       oooooo     o      o  ooo     ooooo      o      ooooo   ooooo     ooooo     ");
            Console.WriteLine("       o          o      o  o o     o   o      o      o       o o           o     ");
            Console.WriteLine("       o        ooooo    ooooo      o   o      o      ooooo   o  o      ooooo     ");
            Console.WriteLine(" ");
            Console.WriteLine("=====================================================================================");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        static void help()
        {
            Console.WriteLine("IN SINGLE PLAYER WITH COMPUTER");
            Console.WriteLine("Player will move with LEFT,RIGHT,UP,DOWN key");
            Console.WriteLine("For fire press SPACE");
            Console.WriteLine("ENEMY also generated from black hole you also need to kill them.");
            Console.WriteLine("When you kill the enemy you got score");
            Console.WriteLine("When you kill the computer player you will win the game.");
            Console.WriteLine(" ");

            Console.WriteLine("IN MULTI_PLAYER ");
            Console.WriteLine("Player 1 will move with LEFT,RIGHT,UP,DOWN key");
            Console.WriteLine("Player 2 will move with A for LEFT,D for RIGHT,W for UP,X for DOWN key");
            Console.WriteLine("For fire player 1 press SPACE");
            Console.WriteLine("For fire player 2 press 0");
            Console.WriteLine("ENEMY also generated from black hole you also need to kill them.");
            Console.WriteLine("BOTH got score on killing the enemy");
            Console.WriteLine("Who kill first the other player that will win the game");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            clear_screen();
        }

        static int enemyDirection()
        {
            srand(time(0));
            int result = 1 + (rand() % 4);
            return result;
        }
    }
}
