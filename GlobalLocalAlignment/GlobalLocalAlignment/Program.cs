using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalLocalAlignment
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = { '-', 'A', 'G', 'C' };
            char[] second = { '-', 'A', 'A', 'A', 'C' };

            ScoringMatrix simon = new ScoringMatrix(first,second);
            OptimumMatrix jack = new OptimumMatrix(first, second);

            for (int i = 1; i < first.Length; i++)
            {
                for (int j = 1; j < second.Length; j++)
                {
                    jack.setScore(i, j, simon.calcCell(i, j));
                }
            }
            int[] maxPos = simon.getMaxScorePos();
            string[] paul = jack.calcOptPathFrom(maxPos[0],maxPos[1]);
            Console.WriteLine(paul[0]);
            Console.WriteLine(paul[1]);
        }
    }
}
