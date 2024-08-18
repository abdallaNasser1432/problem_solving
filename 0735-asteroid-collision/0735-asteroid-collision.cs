public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();
        stack.Push(asteroids[0]);
        for (int i = 1; i < asteroids.Length; i++)
        {
            if (stack.Count() > 0 && asteroids[i] < 0 && stack.Peek() > 0)
            {
                if (Math.Abs(asteroids[i]) > stack.Peek())
                {
                    stack.Pop();
                    stack.Push(asteroids[i]);
                    while (stack.Count() > 1 && stack.Peek() < 0)
                    {
                        int temp = stack.Pop();
                        if (stack.Peek() > 0 && Math.Abs(temp) == stack.Peek()) stack.Pop();
                        else if (stack.Peek() > 0 && Math.Abs(temp) > stack.Peek())
                        {
                            stack.Pop();
                            stack.Push(temp);
                        }
                        else if (stack.Peek() < 0){
                            stack.Push(temp);
                            break;
                        }
                    }
                }
                else if (Math.Abs(asteroids[i]) == stack.Peek()) stack.Pop();

            }
            else
                stack.Push(asteroids[i]);
        }
        return stack.Reverse().ToArray();
    }
}