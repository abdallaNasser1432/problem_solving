public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int totalBottles = numBottles;

        while (numBottles >= numExchange) {
            int newBottles = numBottles / numExchange;
            int remainingBottles = numBottles % numExchange;
            totalBottles += newBottles;
            numBottles = newBottles + remainingBottles;
        }

        return totalBottles;
    }
}