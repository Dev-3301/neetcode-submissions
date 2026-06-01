public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> nums_freq = new Dictionary<int,int>();
        for(int i = 0; i < numbers.Length; i++){
            int second = target - numbers[i];
            if(nums_freq.ContainsKey(second)){
                return [nums_freq[second] + 1, i + 1];
            }else{
                nums_freq.Add(numbers[i], i);
            }
        }
        return [];
    }
}
