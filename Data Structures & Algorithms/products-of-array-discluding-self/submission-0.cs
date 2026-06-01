public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        int total_product = 1;
        int zero_index = Array.IndexOf(nums, 0);

        for(int i = 0; i < nums.Length; i++){
            if (i != zero_index)
            {
                total_product *= nums[i];
            }
        }

        if(zero_index == -1){
            for(int i = 0; i < nums.Length; i++){
                if(i != zero_index){
                    output[i] = 0;
                }else{
                    output[i] = total_product;
                }
            }
        }


        for(int i = 0; i < nums.Length; i++){
            if(zero_index == -1){
                output[i] = total_product / nums[i];
            }else{
                if(i == zero_index){
                    output[i] = total_product;
                }else{
                    output[i] = 0;
                }
            }
        }

        return output;
    }
}
