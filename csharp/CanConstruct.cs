namespace Problems;

public class Construct{

    // (Leetcode: Easy)
    // Given two strings ransomNote and magazine, return true if ransomNote can be constructed
    // by using the letters from magazine and false otherwise.
    // Each letter in magazine can only be used once in ransomNote.
    // fairly trivial.
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length <= magazine.Length){

            List<char> magList = magazine.ToCharArray().ToList();
            for (int i = 0; i < ransomNote.Length; i++){

                if (magList.Contains(ransomNote[i])){
                    magList.Remove(ransomNote[i]);
                }
                else{
                    return false;
                }
            }
            return true;
        }
        else{
            return false;
        }
    }
}