using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPolindrome(string word)
		{
			var reverse = "";
			for (int i = word.Length - 1; i >= 0; i--)
			{
				reverse += word[i];
			}
			if (reverse. ToLower() == word.ToLower())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

