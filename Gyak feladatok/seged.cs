using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_feladatok
{
    internal class Seged
    {
        public int getFirstIndex(int[] tomb)
        {
            int min = tomb[0];
            int index = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    index = i;
                    min = tomb[i];
                }
            }

            return index;
        }


        public int getLastIndex(int[] tomb)
        {
            int max = tomb[0];
            int index = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] >= max)
                {
                    index = i;
                    max = tomb[i];
                }
            }

            return index;
        }
    }
}
