namespace Codewars
{
  public class RemoveStringSpacesClass
  {
    public static string RemoveStringSpaces(string input)
    {
      return String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
    }
  }
}
