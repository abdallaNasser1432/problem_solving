public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        
        List<int> results = new List<int>();

        if (expression.Length == 0) return results;

        if ((expression.Length == 1 ) || (expression.Length == 2 && char.IsDigit(expression[0])))
        {
            results.Add(int.Parse(expression));
            return results;
        }

        for (int i = 0; i < expression.Length; i++)
        {
            char currentChar = expression[i];

            if (char.IsDigit(currentChar)) continue;

            var leftResults = DiffWaysToCompute(expression.Substring(0, i));
            var rightResults = DiffWaysToCompute(expression.Substring(i + 1));

            foreach (int leftValue in leftResults)
            {
                foreach (int rightValue in rightResults)
                {
                    int computedResult = 0;

                    computedResult = currentChar switch
                    {
                        '+' => leftValue + rightValue,
                        '-' => leftValue - rightValue,
                        '*'=>  leftValue * rightValue,
                    };
                    results.Add(computedResult);
                }
            }
        }

        return results;
    }
}