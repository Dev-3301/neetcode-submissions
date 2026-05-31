public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> nums_freq = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int second = target - nums[i];
            if(nums_freq.ContainsKey(second)){
                return [nums_freq[second], i];
            }
            nums_freq.Add(nums[i], i);
        }
        return [];
    }
}
