public class Solution {
    public bool hasDuplicate(int[] nums) {
        //hashmap to store unseen numbers 

        //loop through array
        //if not exists in hashmap, then not seen so add to hashmap, continue
        //if exists in hashmap, then duplicate, set to false 
        HashSet<int> seen = new HashSet<int>();

        foreach (var num in nums) {
            if (seen.Contains(num)) {
                return true;
            } else {
                seen.Add(num);
            }
        }

        return false;
    }
}