/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

class Solution {
public:
    int guessNumber(int n) {
        int left=1; int right=n;
        
        while(true){
            int mid=(right-left)/2+left;
            int num=guess(mid);
            if(num==0)
                return mid;
            else if(num==-1)
                right=mid-1;
            else
                left=mid+1;
        }
    }
    };