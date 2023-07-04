 namespace Problems;
 
// Taking a string of Roman numbers and converting into integers. (Leetcode: Easy)
// Ended up with two solutions. Trade off between runtime and memory
public class RomanToInt{
     public int RomanToInt1(string s) {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M",1000}
        };
        int ans = 0;
        for (int i = 0; i < s.Length - 1; i++){
            if (dict[s[i].ToString()] < dict[s[i + 1].ToString()]){
                ans -= dict[s[i].ToString()];
            }
            else{
                ans += dict[s[i].ToString()];
            }
        }
        ans += dict[s[s.Length - 1].ToString()];
        return ans;
    }
     public int RomanToInt2(string s) {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M",1000}
        };
        int total = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--) {
            int currValue = dict[s[i].ToString()];

            if (currValue >= prevValue) {
                total += currValue;
            } else {
                 total -= currValue;
            }

            prevValue = currValue;
        }
        return total;
    }
}