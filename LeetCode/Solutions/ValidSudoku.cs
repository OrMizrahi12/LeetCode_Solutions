using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            if (!CheckBoxses(board)) 
                return false;
            else if (!CheckRows(board))
                return false;
            else if (!CheckCols(board))
                return false;    
            
            return true;
        }
        static public bool CheckCols(char[][] row)
        {
            int RowDup = 0;

            for (int i = 0; i < row.Length; i++)
            {
                for (int j = 0; j < row.Length; j++)
                {
                    for (int k = 0; k < row.Length; k++)
                    {
                        if (row[k][i] == row[j][i] && Char.IsNumber(row[k][i]) && Char.IsNumber(row[j][i]))
                        {
                            RowDup++;
                        }
                    }
                    if (RowDup > 1)
                    {
                        return false;
                    } 
                    RowDup = 0;
                }
            }
                
            return true;
        }
        public static bool CheckBoxses(char[][] c)
        {
            List<char> box = new List<char>();
            int fromIndex_I = 0;
            int fromIndex_J = 0;

            for (int l = 0; l < c.Length; l++)
            {
                for (int i = fromIndex_I; i < fromIndex_I + 3; i++)
                {
                    for (int j = fromIndex_J; j < fromIndex_J + 3; j++)
                    {
                        box.Add(c[i][j]);   
                    }
                    if(box.Count == 9)
                    {
                        if(!CheckBox(box))
                        {
                            return false;
                        }
                        box.Clear();
                    }
                }

                fromIndex_J += 3;
                if (fromIndex_J == c.Length)
                {
                    fromIndex_J = 0;
                    fromIndex_I += 3;
                }
            }
            return true;
        }
       static public bool CheckBox(List<char> chars)
       {
            int dup = 0;
            for (int i = 0; i < chars.Count; i++)
            {
                for (int j = 0; j < chars.Count; j++)
                {
                    if(chars[i] == chars[j] && Char.IsNumber(chars[i]) && Char.IsNumber(chars[j]))
                    {
                        dup++;
                    }
                }
                if( dup > 1)
                {
                    return false;
                }
                dup = 0;
            }   
            return true;
       }

        public static bool CheckRows(char[][] bored)
        {
            int dup = 0;
            for (int i = 0; i < bored.Length; i++)
            {
                for (int j = 0; j < bored.Length; j++)
                {
                    for (int k = 0; k < bored.Length; k++)
                    {
                        if (Char.IsNumber(bored[i][j]) && Char.IsNumber(bored[i][k]) && bored[i][j] == bored[i][k])
                        {
                            dup++;
                        }
                    }
                    if (dup > 1)
                    {
                        return false;
                    } 
                    dup = 0; 
                }
            }
            return true;
        }
    }
}