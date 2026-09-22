public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> store = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int lookup = target - nums[i];
            if(store.ContainsKey(lookup)){
                return [store[lookup], i];
            }
            store[nums[i]] = i;
        }
        return [];
    }
}
