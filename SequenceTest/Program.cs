using System;

namespace SequenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = {1, 4, 9, 16, 9, 7, 4, 9, 11};
            int total = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if(i % 2 == 0)
                {
                    total += sequence[i];
                }else{
                    total -= sequence[i];
                }
            }
            Console.Write(total);
        }
    }
}
