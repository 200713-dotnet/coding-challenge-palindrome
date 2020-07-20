using Palindrome.Domain.Models;
using Xunit;

namespace Palindrome.Testing.Tests
{
  public class PalindromeTest
  {
    [Theory]
    [InlineData("tacocat")]
    public void Test_Words(string word)
    {
      var sut = new Palindrome.Domain.Models.Palindrome();
      var actual = sut.IsPalindrome(word);

      Assert.True(actual);
    }
  }
}