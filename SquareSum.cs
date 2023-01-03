namespace Codewars
{
  public class SquareSumClass
  {
    public static int SquareSum(int[] numbers)
    {
      int output = 0;
      foreach (int number in numbers)
      {
        output += (number * number);
      }
      return output;
    }
  }
}
