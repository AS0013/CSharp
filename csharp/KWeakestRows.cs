namespace Problems;

public class KWeakestRows{

// solved.

// The K Weakest Rows in a Matrix (1337. Leetcode: Easy)
// You are given an m x n binary matrix mat of 1's (representing soldiers)
// and 0's (representing civilians). The soldiers are positioned in front of the civilians.
// That is, all the 1's will appear to the left of all the 0's in each row.
// A row i is weaker than a row j if one of the following is true:
// The number of soldiers in row i is less than the number of soldiers in row j.
// Both rows have the same number of soldiers and i < j.
// Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.

    public int[] kweakestrows(int[][] mat, int k){
        List<Tuple<int, int>> temp = new List<Tuple<int, int>>();
        int rows = mat.Length;
        int cols = mat[0].Length;

        for (int i = 0; i < rows; i++){
            int soldiers = 0;
            for (int j = 0; j < cols; j++){
                if (mat[i][j] == 1){
                    soldiers++;
                }
            }
            temp.Add(new Tuple<int, int>(soldiers, i));
        }
        temp.Sort((x, y) => {
            int soldierComparison = x.Item1.CompareTo(y.Item1);
            if (soldierComparison == 0){
                return x.Item2.CompareTo(y.Item2);
            } else {
                return soldierComparison;
            }
        });
        int[] result = new int[k];
        for (int i = 0; i < k; i++){
            result[i] = temp[i].Item2;
        }
        return result;
    }
}