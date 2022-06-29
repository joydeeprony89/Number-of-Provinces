using System;

namespace Number_of_Provinces
{
  class Program
  {
    static void Main(string[] args)
    {
      var isConnected = new int[4][] { new int[] { 1, 1, 0, 1 }, new int[] { 1, 1, 1, 0 }, new int[] { 0, 1, 1, 0 }, new int[] { 0, 0, 0, 1 } };
      Solution s = new Solution();
      var answer = s.FindCircleNum(isConnected);
      Console.WriteLine(answer);
    }
  }
  public class Solution
  {
    public int FindCircleNum(int[][] isConnected)
    {
      int count = 0;
      int n = isConnected.Length;
      bool[] visited = new bool[n];
      for (int i = 0; i < n; i++)
      {
        if (!visited[i])
        {
          count++;
          DFS(isConnected, i, visited);
        }
      }

      return count;
    }

    private void DFS(int[][] isConnected, int i, bool[] visited)
    {
      for(int j = 0; j < isConnected.Length; j++)
      {
        if(!visited[j] && isConnected[i][j] == 1)
        {
          visited[j] = true;
          DFS(isConnected, j, visited);
        }
      }
    }
  }
}
