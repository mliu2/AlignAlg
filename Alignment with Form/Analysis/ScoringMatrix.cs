using System;

namespace GlobalLocalAlignment
{
    public class ScoringMatrix
    {
        private int[,] theMatrix;
        private char[] top;
        private char[] side;
        private int[] scoringSystem = { 1, -1, -2, -4 }; //int[match,mismatch,indelOpen,indelContinue]

        public ScoringMatrix()
        {
            throw new ScoringClassException("Matrix size not specified");
        }
        public ScoringMatrix(char[] values)//not sure why I did this, I suppose to make sure it gives us 1:1 alignment?
        {
            this.theMatrix = new int[values.Length + 1, values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                this.theMatrix[i, 0] = this.theMatrix[0, i] = i * this.scoringSystem[2];
            }
            this.top = values;
            this.side = values;
        }
        public ScoringMatrix(char[] topRow, char[] sideCol) //build matrix, store sequences, use default scoring system
        {
            this.theMatrix = new int[topRow.Length, sideCol.Length];
            if (topRow.Length == sideCol.Length)
            {
                for (int i = 0; i < topRow.Length; i++)
                {
                    this.theMatrix[i, 0] = this.theMatrix[0, i] = i * this.scoringSystem[2];
                }
            }
            else
            {
                for (int i = 0; i < sideCol.Length; i++)
                {
                    this.theMatrix[0, i] = i * this.scoringSystem[2];
                }
                for (int i = 0; i < topRow.Length; i++)
                {
                    this.theMatrix[i, 0] = i * this.scoringSystem[2];
                }
            }
            this.top = topRow;
            this.side = sideCol;
        }
        public ScoringMatrix(char[] topRow, char[] sideCol, int[] scoringSystem) //build matrix, store sequences, use custom scoring, expecting scores in the form of int[match,mismatch,indelOpen,indelContinue]
        {
            this.theMatrix = new int[topRow.Length, sideCol.Length];
            this.scoringSystem = scoringSystem;
            if (topRow.Length == sideCol.Length)
            {
                for (int i = 0; i < topRow.Length; i++)
                {
                    this.theMatrix[i, 0] = this.theMatrix[0, i] = i * this.scoringSystem[2];
                }
            }
            else
            {
                for (int i = 0; i < sideCol.Length; i++)
                {
                    this.theMatrix[0, i] = i * this.scoringSystem[2];
                }
                for (int i = 0; i < topRow.Length; i++)
                {
                    this.theMatrix[i, 0] = i * this.scoringSystem[2];
                }
            }
            this.top = topRow;
            this.side = sideCol;
        }

        /*
         * Parameters: the row followed by column of cell that we want to calculate
         * Returns: The direction attained (top|left|diagnol), or -1 if it already has a number or if invalid input
         * Side Effect: inputs the calculated number into that cell in theMatrix
         * 
         * Note: (top|left|diagnol) == bits, agreed that 101 implies number was attained from top and diagnol, 1 means attained only from diagnol, etc
         * 
         * TODO: open vs. continue indel logic
         */
        public int calcCell(int row, int col)
        {
            if (row == 0 || col == 0) { return -1; } //these should be filled in by default, also will throw error if continue

            int diagnol = this.theMatrix[row - 1, col - 1] + ((this.top[row] == this.side[col]) ? (this.scoringSystem[0]) : (this.scoringSystem[1]));
            int top = this.theMatrix[row - 1, col] + (this.scoringSystem[2]); //TODO HERE: going with indelOpen for now
            int side = this.theMatrix[row, col - 1] + (this.scoringSystem[2]); //TODO HERE: going with indelOpen for now

            if (diagnol > top)
            {
                if (diagnol > side) { this.theMatrix[row, col] = diagnol; return 1; }
                else if (diagnol == side) { this.theMatrix[row, col] = diagnol; return 11; }
                this.theMatrix[row, col] = side;//if neither of those than side is bigger than diagnol, also not equal to or smaller than top
                return 10;
            }
            else if (diagnol < top)
            {
                if (side < top) { this.theMatrix[row, col] = top; return 100; }
                else if (side == top) { this.theMatrix[row, col] = top; return 110; }
                this.theMatrix[row, col] = side;//if neither of those than side is bigger than diagnol, also not equal to or smaller than top
                return 10;
            }
            else if (diagnol == top)
            {
                if (diagnol == side) { this.theMatrix[row, col] = top; return 111; }
                else if (diagnol > side) { this.theMatrix[row, col] = top; return 101; }
                this.theMatrix[row, col] = side;//if neither of those than side is bigger than diagnol, also not equal to or smaller than top
                return 10;
            }
            Console.WriteLine("I have no idea what happened, this is impossible...");
            throw new ScoringClassException("Somehow Andrew bollocksed the code");

        }
        /*
        * Parameters: the row followed by column of cell that we want to calculate
        * Returns: The direction attained (top|left|diagnol), or -1 if it already has a number or if invalid input
        * Side Effect: inputs the calculated number into that cell in theMatrix
        * 
        * Note: (top|left|diagnol) == bits, agreed that 101 implies number was attained from top and diagnol, 1 means attained only from diagnol, etc
        * NOTE: Should start at 0,0 as opposed to global alignment which starts at 1,1
        * TODO: open vs. continue indel logic
        */
        public int calcCellLocal(int row, int col)
        {
            //Local alignment needs to reset first row and column 
            if (row == 0 || col == 0) {
                this.theMatrix[row, col] = 0;
                return -1;
            } 

            int diagnol = this.theMatrix[row - 1, col - 1] + ((this.top[row] == this.side[col]) ? (this.scoringSystem[0]) : (this.scoringSystem[1]));
            int top = this.theMatrix[row - 1, col] + (this.scoringSystem[2]); //TODO HERE: going with indelOpen for now
            int side = this.theMatrix[row, col - 1] + (this.scoringSystem[2]); //TODO HERE: going with indelOpen for now
            int max = -9999999;
            //Smith Waterman local alignments sets cells that would go negative to 0
            if (diagnol < 0 && top < 0 && side < 0)
            {
                max = 0;
            }
            else
            {
                if (diagnol >= top && diagnol >= side) { max = diagnol; }
                else if (top >= diagnol && top >= side) { max = top; }
                else if (side >= diagnol && side >= top) { max = side; }
                else
                {
                    Console.WriteLine("I have no idea what happened, this is impossible...");
                    throw new ScoringClassException("Somehow Ming bollocksed the code");
                }
            }

            if (diagnol > top)
            {
                if (diagnol > side) { this.theMatrix[row, col] = max; return 1; }
                else if (diagnol == side) { this.theMatrix[row, col] = max; return 11; }
                this.theMatrix[row, col] = side;//if neither of those than side is bigger than diagnol, also not equal to or smaller than top
                return 10;
            }
            else if (diagnol < top)
            {
                if (side < top) { this.theMatrix[row, col] = max; return 100; }
                else if (side == top) { this.theMatrix[row, col] = max; return 110; }
                this.theMatrix[row, col] = side;//if neither of those than side is bigger than diagnol, also not equal to or smaller than top
                return 10;
            }
            else if (diagnol == top)
            {
                if (diagnol == side) { this.theMatrix[row, col] = max; return 111; }
                else if (diagnol > side) { this.theMatrix[row, col] = max; return 101; }
                this.theMatrix[row, col] = side;//if neither of those than side is bigger than diagnol, also not equal to or smaller than top
                return 10;
            }
            Console.WriteLine("I have no idea what happened, this is impossible...");
            throw new ScoringClassException("Somehow Ming bollocksed the code");

        }

        public int getPos(int row, int col) { return this.theMatrix[row, col]; }

        public int[] getMaxScorePos()
        {
            int[] max = new int[2];
            int highest = -999999999;
            for (int i = 0; i < this.top.Length; i++)
            {
                if (this.theMatrix[i, this.side.Length - 1] > highest) { max[0] = i; max[1] = this.side.Length - 1; highest = this.theMatrix[i, this.side.Length - 1]; }
            }
            for (int i = 0; i < this.side.Length; i++)
            {
                if (this.theMatrix[this.top.Length - 1, i] > highest) { max[0] = this.top.Length - 1; max[1] = i; highest = this.theMatrix[this.top.Length - 1, i]; }
            }
            return max;
        }
    }
    public class ScoringClassException : Exception
    {
        public ScoringClassException()
        {
        }

        public ScoringClassException(string message)
            : base(message)
        {
        }
    }
}
