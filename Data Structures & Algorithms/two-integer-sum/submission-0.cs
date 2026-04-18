public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numsDict = new Dictionary<int, int>();
        numsDict.Add(target-nums[0], 0);
        for(int i = 1; i < nums.Length; i++){
            var key = target-nums[i];
            if(numsDict.ContainsKey(target-key)){
                return new[] {numsDict[target-key], i};
            }
            numsDict.Add(key, i);
        }
        return new int[0];
    }
}
