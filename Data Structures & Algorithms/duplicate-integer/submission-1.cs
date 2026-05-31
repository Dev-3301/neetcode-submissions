public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> nums_freq = new Dictionary<int, int>();
        foreach(var num in nums){
            if(nums_freq.ContainsKey(num)){
                return true;
            }
            nums_freq[num] = 1;
        }
        return false;
    }
}