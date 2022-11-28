namespace Codewars
{
  public class ReversedStringsClass
  {
    public static string ReversedStrings(string str)
    {
      string finalStr = "";
    
      for (int i = 1; i <= str.Length; i++)
      {
        finalStr += str[str.Length - i];
      }
      
      return finalStr;
    }
  }
}
