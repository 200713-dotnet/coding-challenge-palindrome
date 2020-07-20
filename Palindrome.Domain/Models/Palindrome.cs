using System;
using System.Linq;

namespace Palindrome.Domain.Models
{
  public class Palindrome
  {
    public bool IsPalindrome(string input)
    {
      var s = input.ToCharArray();
      Array.Reverse(s);

      return input == string.Join("", s);
    }
  }
}