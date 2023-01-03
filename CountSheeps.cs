namespace Codewars
{
  public class CountSheepsClass
  {
    public static int CountSheeps(bool[] sheeps)
    {
      int output = 0;
      foreach (bool sheep in sheeps)
      {
        if (sheep) output++;
      }
      return output;
    }
  }
}
