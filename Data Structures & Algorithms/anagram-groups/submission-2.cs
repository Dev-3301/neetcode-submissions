public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> matchingList = new Dictionary<string, List<string>>();
        List<List<string>> outputList = new List<List<string>>();
        foreach(var word in strs.ToList()){
            string sorted_word = String.Concat(word.OrderBy(c => c));
            if (!matchingList.ContainsKey(sorted_word))
            {
                matchingList[sorted_word] = new List<string>();
            }
            matchingList[sorted_word].Add(word);
        }
        foreach(var (k, v) in matchingList){
            outputList.Add(v);
        }
        return outputList;
    }
}
