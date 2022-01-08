using System;

public class Program
{
  /*
  Description : The goal of this exercise is to convert a string to a new string where each
  character in the new string is "(" if that character appears only once in the original string,
  or ")" if that character appears more than once in the original string. Ignore capitalization
  when determining if a character is a duplicate. 
  Examples
  "din"      =>  "((("
  "recede"   =>  "()()()"
  "Success"  =>  ")())())"
  "(( @"     =>  "))((" 
  */
  
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