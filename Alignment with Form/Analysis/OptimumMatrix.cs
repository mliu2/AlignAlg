using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalLocalAlignment
{
    class OptimumMatrix
    {
        private int[,] theMatrix;
        private char[] top;
        private char[] side;

        //code = (top,left,diagnol) in a three digit number of 1s and 0s;

        public OptimumMatrix() { throw new OptimumClassException("Matrix size not specified"); }
        public OptimumMatrix(char[] values)//not sure why I did this, I suppose to make sure it gives us 1:1 alignment?
        {
            this.theMatrix = new int[values.Length + 1, values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                this.theMatrix[i, 0] = 100;
                this.theMatrix[0, i] = 10; 
            }
            this.top = values;
            this.side = values;
        }
        public OptimumMatrix(char[] topRow, char[] sideCol) //build matrix, store sequences
        {
            this.theMatrix = new int[topRow.Length, sideCol.Length];
            if (topRow.Length == sideCol.Length)
            {
                for (int i = 0; i < topRow.Length; i++)
                {
                    this.theMatrix[i, 0] = 100;
                    this.theMatrix[0, i] = 10;
                }
            }
            else
            {
                for (int i = 0; i < sideCol.Length; i++)
                {
                    this.theMatrix[0, i] = 100;
                }
                for (int i = 0; i < topRow.Length; i++)
                {
                    this.theMatrix[i, 0] = 10;
                }
            }
            this.theMatrix[0, 0] = 0;
            this.top = topRow;
            this.side = sideCol;
        }

        /*
         * Paramters: row/col position of the cell, the score
         * Side-effects: alters theMatrix
         * Returns: nada
         * 
         * Will overwrite a value with no buts
         */
        public void setScore(int row, int column, int score)
        {
            if (row == 0 || column == 0)
                Console.WriteLine("You realize you're overwriting default values, right?");
            this.theMatrix[row, column] = score;
        }

        public string[] calcOptPathFrom(int row, int col)
        {
            string sideString = "", topString = "";

            while (true)
            {
                if ((this.theMatrix[row, col] / 100) == 1)
                { 
                    topString = this.top[row] + topString;
                    sideString = '-' + sideString;
                    
                    row--;
                }
                else if ((this.theMatrix[row, col] / 10) == 1)
                {
                   topString = '-' + topString;
                    sideString = this.side[col] + sideString;
                    col--;
                }
                else
                {
                    topString = this.top[row] + topString;
                    sideString = this.side[col] + sideString;
                    if (row != 0) row--;
                    if (col != 0) col--;
                }
                if (row == 0 && col == 0)
                {
                    break;
                }
            }
            string[] answer = { topString, sideString };
            return answer;
        }
    }

    public class OptimumClassException : Exception
    {
        public OptimumClassException()
        {
        }

        public OptimumClassException(string message)
            : base(message)
        {
        }
    }
}
