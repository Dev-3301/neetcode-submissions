public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> words_count = new Dictionary<char, int>();
        if(s.Length < t.Length || t.Length < s.Length){
            return false;
        }
        int length = s.Length;
        for(int i = 0; i < length; i++){
            words_count[s[i]] = words_count.GetValueOrDefault(s[i], 0) + 1;
            words_count[t[i]] = words_count.GetValueOrDefault(t[i], 0) + 1;
        }

        foreach(var key in words_count.Keys){
            if (!s.Contains(key) || !t.Contains(key))
            {
                return false;
            }
            if(words_count[key] == 1 || words_count[key] % 2 != 0){
                return false;
            }
        }
        return true;
    }
}
