public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        //counter initialize to 0
        //loop through every element
        //if value = 1 then increment counter
        //if value = 0 then do nothing

        int max = 0;
        int counter = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                counter++;
            };

            if (counter > max) {
                max = counter;
            };

            if (nums[i] == 0) {
                counter = 0;
            }
        };

        return max;
    }
}