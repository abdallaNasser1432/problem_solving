class Solution {
public:
bool isValidSudoku(vector<vector<char>>& board) {
    set<char>row;set<int>col;
    int countRow=0,countCol=0;
    for (int i = 0; i < 9; ++i) {
        countRow=0,countCol=0;
        row.clear();col.clear();
        for (int j = 0; j <9  ; ++j) {
            if(isdigit(board[i][j])){
                countRow++;row.insert(board[i][j]);
            }
            if(isdigit(board[j][i])){
                countCol++;col.insert(board[j][i]);
            }
        }
        if (row.size()!=countRow or col.size() !=countCol)
            return false;
    }
    set<char>subArr;int countSub=0; int start=0,end=3; bool flag= false;
    for (int i = 0; i <3 ; ++i) {
        flag= false;
        for (int j = start; j <end and j<9 ; ++j) {
            if(isdigit(board[i][j])){
                countSub++;subArr.insert(board[i][j]);
            }
            flag= true;
        }
        if (subArr.size()!=countSub) return false;
        if (i==2){
            start+=3;end+=3;
            i=-1;
            countSub=0;subArr.clear();
        }
        if (flag== false)break;
    }
    subArr.clear();countSub=0;start=0,end=3; flag= false;
    for (int i = 3; i <6 ; ++i) {
        flag= false;
        for (int j = start; j <end and j<9 ; ++j) {
            if(isdigit(board[i][j])){
                countSub++;subArr.insert(board[i][j]);
            }
            flag= true;
        }
        if (subArr.size()!=countSub) return false;
        if (i==5){
            start+=3;end+=3;
            i=2;
            countSub=0;subArr.clear();
        }
        if (flag== false)break;
    }
    subArr.clear();countSub=0;start=0,end=3; flag= false;
    for (int i = 6; i <9 ; ++i) {
        flag= false;
        for (int j = start; j <end and j<9 ; ++j) {
            if(isdigit(board[i][j])){
                countSub++;subArr.insert(board[i][j]);
            }
            flag= true;
        }
        if (subArr.size()!=countSub) return false;
        if (i==8){
            start+=3;end+=3;
            i=5;
            countSub=0;subArr.clear();
        }
        if (flag == false)break;
    }

    return true;
}

/*
      0 0 0    0 0 0    5 0 0
      0 0 0    0 0 0    0 0 0
      0 0 0    0 0 0    0 0 0
      
      9 3 0    0 2 0    4 0 0
      0 0 7    0 0 0    3 0 0
      0 0 0    0 0 0    0 0 0
      
      0 0 0    3 4 0    0 0 0
      0 0 0    0 0 3    0 0 0
      0 0 0    0 0 5    2 0 0


*/
    
};