public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> s_counter = new Dictionary<char, int>();
        Dictionary<char, int> t_counter = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){
            s_counter[s[i]] =  s_counter.GetValueOrDefault(s[i], 0) + 1;
            t_counter[t[i]] = t_counter.GetValueOrDefault(t[i], 0) + 1;
        }
        char key;
        foreach(var (k, v) in s_counter){
            int t_v = t_counter.GetValueOrDefault(k, 0);
            if(v != t_v){
                return false;
            }
        }

        return true;
    }
}
