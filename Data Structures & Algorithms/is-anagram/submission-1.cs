public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> charFreqS = new Dictionary<char, int>();
        Dictionary<char, int> charFreqT = new Dictionary<char, int>();

        for(int i = 0; i < t.Length; i++)
        {
            if (charFreqS.ContainsKey(s[i]))
            {
                charFreqS[s[i]]++;
            }
            else
            {
                charFreqS.Add(s[i], 1);
            }
            if (charFreqT.ContainsKey(t[i]))
            {
                charFreqT[t[i]]++;
            }
            else
            {
                charFreqT.Add(t[i], 1);
            }
        }
        for(int i = 0; i < s.Length; i++)
        {
            if (charFreqS.ContainsKey(s[i]) && charFreqT.ContainsKey(s[i]))
            {
                if(charFreqS[s[i]] != charFreqT[s[i]]){
                    return false;
                }

            }else{
                return false;
            }
        }
        return true;
    }
}
