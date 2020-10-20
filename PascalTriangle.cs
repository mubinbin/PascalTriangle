using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    public class PascalTriangle
    {
        public static List<int> Layer(int num)
        {
            List<int> ans = new List<int>();
            if(num == 1 || num == 0)
            {
                ans.Add(num);
                return ans;
            }else if (num==2){
                ans.Add(1);
                ans.Add(2);
                ans.Add(1);
                return ans;
            }else{
                for(int i =0; i <=num; i++)
                {
                    
                    if(i==0||i==num){
                        ans.Add(1);
                    }else if(i<=num/2){

                        ans.Add(Layer(num-1)[i] + Layer(num-1)[i-1]);
                        
                    }else{
                        ans.Add(ans[num-i]);
                    }
                }
                return ans;
            }
        }
    }
}
