public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> score = new Stack<int>();

        foreach (var ops in operations) {
            if (ops == "C") {
                score.Pop();
            } else if (ops == "D") {
                score.Push(2 * score.Peek());
            } else if (ops == "+") {
                int top = score.Pop();
                int newTop = top + score.Peek();
                score.Push(top);
                score.Push(newTop);
            } else {
                score.Push(int.Parse(ops));
            }
        }

        int total = 0;
        foreach (var sc in score) {
            total += sc;
        }

        return total;
    }
}