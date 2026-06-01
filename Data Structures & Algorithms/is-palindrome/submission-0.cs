public class Solution {
    public bool IsPalindrome(string s) {
        string result = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        for(int i = 0; i < result.Length; i++){
            if(result[i] != result[result.Length-i-1]){
                return false;
            }
        }
        return true;
    }
}
