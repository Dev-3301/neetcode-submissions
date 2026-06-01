public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> nums_freq = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(nums_freq.ContainsKey(nums[i])){
                nums_freq[nums[i]] += 1;
            }else{
                nums_freq.Add(nums[i], 1);
            }

        }
        int[] sorted_nums = nums_freq.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();
        int[] output = new int[k];
        for(int i = 0; i < k; i++){
            output[i] = sorted_nums[i];
        }
        return output;
    }
}
