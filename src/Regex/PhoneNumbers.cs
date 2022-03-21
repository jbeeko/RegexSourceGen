namespace SourceGenedRegex;
using System.Text.RegularExpressions;
public partial class PhoneNumbers  // <-- Make the class a partial class
{
  [RegexGenerator(@"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$", RegexOptions.IgnoreCase)] // <-- Add the RegexGenerator attribute and pass in your pattern and options
  public static partial Regex TenDigitNumber(); //  <-- Declare the partial method, which will be implemented by the source generator
}