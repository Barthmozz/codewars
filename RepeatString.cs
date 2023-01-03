namespace Codewars
{
  public class RepeatStringClass
  {
    public static string RepeatString(int n, string s)
    {
      string output = "";
      for (int i = 0; i < n; i++)
      {
        output += s;
      }
      return output;
    }
  }
}
