using System;
using System.Collections.Generic;
using System.Text;

namespace JobNimbusAssessment
{
    //Assumptions:
    // String can have other characters apart from { and }
    public class MatchingBrackets
    {
        // Approach 1
        public bool HasMatchingBrackets_Approach1(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            int openCount = 0;
            foreach (char c in input)
            {
                if (c == '}')
                {
                    // Whenever we encounter a close bracket, we decrement the openCount if it is greater than 0. 
                    // Else, we return false since there are no open brackets for this close bracket
                    if (openCount > 0)
                    {
                        openCount--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == '{')
                {
                    // Whenever we encounter an open bracket, we increment openCount
                    openCount++;
                }
                else
                {
                    // No action needed for anything except { and }
                    continue;
                }
            }

            return openCount == 0;
        }

        // Approach 2
        public bool HasMatchingBrackets_Approach2(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            Stack<char> st = new Stack<char>();

            /* Dictionary can be used to save corresponding open and close brackets if this were to be generalized for other types of parentheses like (,[.
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('}', '{');
            */

            foreach (char c in input)
            {
                if (c == '}')
                {
                    // Whenever we encounter a close bracket, we check the top of the stack to see if its open bracket.
                    if (st.Count > 0)
                    {
                        if (st.Pop() != '{')
                            return false;
                    }
                    else
                        return false;
                }
                else if (c == '{')
                {
                    // Whenever we encounter an open bracket, we push it into the stack.
                    st.Push(c);
                }
                else
                {
                    // No action needed for anything except { and }
                    continue;
                }
            }

            return st.Count == 0;
        }        
    }
}
