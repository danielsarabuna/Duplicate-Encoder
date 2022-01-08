using System;

public class Program
{  
  public static string DuplicateEncode(string word)
  {
    char[] arr = word.ToCharArray();
    string result = string.Empty;

    for (int i = 0; i < arr.Length; i++)
    {
      int countChar = 0;
      for (int k = 0; k < arr.Length; k++)
        if (Char.ToUpper(arr[i]) == Char.ToUpper(arr[k])) countChar++;
      result += countChar <= 1 ? "(" : ")";
    }

    return result;
  }
}