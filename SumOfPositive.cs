namespace Codewars
{
  public class CodewarsClass
  {
    public static int PositiveSum(int[] arr)
    {
      return arr.Where((x) => x > 0).Sum();
    }
  }
}
