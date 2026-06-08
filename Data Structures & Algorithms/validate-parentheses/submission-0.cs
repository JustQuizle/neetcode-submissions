public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> paranthesesMapping = new Dictionary<char, char> {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        foreach (var c in s) {
            if (paranthesesMapping.ContainsKey(c)) {
                if (stack.Count > 0 && stack.Peek() == paranthesesMapping[c]) {
                    stack.Pop();
                } else {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
