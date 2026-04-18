public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> lookup = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(lookup.ContainsKey(nums[i])){
                return true;
            }
            lookup.Add(nums[i], i);
        }
        return false;
    }
}