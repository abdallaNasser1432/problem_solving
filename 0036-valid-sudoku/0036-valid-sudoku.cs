public class Solution {
     public bool IsValidSudoku(char[][] board) {
         
         HashSet<char> set = new();

         //iterate on all rows
         for (int i = 0; i < 9; i++)
         {
             for (int j = 0; j < 9; j++)
             {
                 if (board[i][j] == '.') continue;
                 if (set.Contains(board[i][j])) return false;
                 set.Add(board[i][j]);
             }
             set.Clear();
         }

         //iterate on all colums 
         for (int i = 0; i < 9; i++)
         {
             for (int j = 0; j < 9; j++)
             {
                 if (board[j][i] == '.') continue;
                 if (set.Contains(board[j][i])) return false;
                 set.Add(board[j][i]);
             }
             set.Clear();
         }

         // iterate on all sub-boxes 
         int k = 0, m = 0;
         while (k < 9 && m < 9)
         {
             for (int i = k; i < k + 3; i++)
             {
                 for (int j = m; j < m + 3; j++)
                 {
                     if (board[i][j] == '.') continue;
                     if (set.Contains(board[i][j])) return false;
                     set.Add(board[i][j]);
                 }
             }
             set.Clear();
             k += 3;
             if (k >= 9) // tricky
             {
                 k = 0;
                 m += 3;
             }  

         }
         return true;
     }
}