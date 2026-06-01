public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0){
            return 0;
        }
        HashSet<int> unique_numbers = nums.ToHashSet();
        List<int> sorted_nums = unique_numbers.OrderBy(x => x).ToList();
        int max_seq = 1;
        int current_seq = 1;
        for(int i = 1; i < sorted_nums.Count; i++){
            if(sorted_nums[i]== sorted_nums[i-1] +1){
                current_seq++;
            }else{
                max_seq = Math.Max(max_seq,current_seq);
                current_seq = 1;
            }
        }
        max_seq = Math.Max(max_seq, current_seq);
        return max_seq;
    }
}
