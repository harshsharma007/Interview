using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class ChessExercise
    {
        public void Chess()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    switch (i % 2)
                    {
                        case 0:
                            switch (j % 2)
                            {
                                case 0:
                                    Console.Write("X");
                                    break;
                                case 1:
                                    Console.Write("O");
                                    break;
                            }
                            break;
                        case 1:
                            switch (j % 2)
                            {
                                case 0:
                                    Console.Write("O");
                                    break;
                                case 1:
                                    Console.Write("X");
                                    break;
                            }
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
