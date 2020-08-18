using System;
using System.Collections.Generic;
using System.Text;

namespace JobNimbusAssessment
{
    class SumOfMultiples
    {
        public int SumofMultiples(int limit)
        {
            int sum = 0;
            for(int num = 0; num < limit; num++)
            {
                if(num % 3 == 0 || num % 5 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
