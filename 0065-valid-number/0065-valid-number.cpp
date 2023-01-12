class Solution {
public:
    bool isNumber(string S) {
        bool number = false, exp = false, pluseOrNegative = false, dec = false;
        for (auto i : S)
            if (i >= '0' and i <= '9')
                number = true ;
            else if (i == 'e' or i == 'E')
                if (exp or !number) // for this case e ,23423e ,243e234e
                    return false;
                else exp = true, pluseOrNegative = false, number = false, dec = false;
            else if (i == '+' or i == '-')
                if (pluseOrNegative or number or dec)// for this case ++ , +-, 43+ ,+.
                    return false;
                else pluseOrNegative = true;
            else if (i == '.')
                if (dec or exp)//for this case  .. , e.
                    return false;
                else dec = true;
            else
                return false; // mean is a  letter 
        return number;
    }
};