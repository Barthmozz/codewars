namespace Codewars
{
  public class SummationClass
  {
    public static int Summation(int num)
    {
      int output = 0;
      for (int i = num; i >= 1; i--)
      {
        output += i;
      }
      return output;
    }
  }
}
