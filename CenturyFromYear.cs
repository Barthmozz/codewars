namespace Codewars
{
  public class CCenturyFromYearClass
  {
    public static int CenturyFromYear(int year)
    {
      return year % 100 == 0 ? year / 100 : year / 100 + 1;
    }
  }
}
