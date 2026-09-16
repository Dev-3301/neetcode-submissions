public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> nums_dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!nums_dict.TryAdd(nums[i], 0)){
                return true;
            }
        }
        return false;
    }
}