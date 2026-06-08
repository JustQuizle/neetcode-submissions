public class Solution {
    public int[] ReplaceElements(int[] arr) {

        for (int i = 0; i < arr.Length; i++) {
            int rightMax = -1;
            for (int j = i + 1; j < arr.Length; j++) {
                rightMax = Math.Max(rightMax, arr[j]);
            };

            arr[i] = rightMax;
        };

        return arr;
    }
}