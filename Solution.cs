using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Solution
    {
      
        public int solution(int[] A)
        {

            int min = int.MaxValue;

            bool positive = false;

            foreach (int i in A)
            {
               if(i>0)
                {
                    min = Math.Min(min, i);
                    positive = true; 
                       
                }  
            }
         return  positive ? min : 0; 

            
           
        }
    }
}
