using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace kata
{
 using NUnit.Framework;

[TestFixture]
 public class MargGuessTest
  {


	[TestCase("rgyb","xxxx","")]
	[TestCase("rgyb","xxxr","m")]
	[TestCase("rgyb","xxgy","mm")]
	[TestCase("rgyb","xrgy","mmm")]
	[TestCase("rgyb","brgy","mmmm")]
	[TestCase("rgyb","rxxx","p")]
	[TestCase("rgyb","rgxx","pp")]
	[TestCase("rgyb","rgyx","ppp")]
	[TestCase("rgyb","rgyb","pppp")]
	[TestCase("rgyb","rgyb","pppp")]
	[TestCase("rgyb","rgby","ppmm")]
	[TestCase("rggg","rgyy","pp")]
	[TestCase("rgxx","rggg","pp")]
	public void TestMarkGuess(string secret, string guess,string returned)
	{
			List<char> lSecret = secret.ToList();
			List<char> lGuess = guess.ToList();
			Assert.AreEqual(returned,MarkGuess.Guess(lSecret,lGuess));
	}

		  
		

	/*
secret, guess, result: 


[TestCase("rgyb","xxxx","")]
[TestCase("rgyb","xxxr","m")]
[TestCase("rgyb","xxgy","mm")]
[TestCase("rgyb","xrgy","mmm")]
[TestCase("rgyb","brgy","mmmm")]
[TestCase("rgyb","rxxx","p")]
[TestCase("rgyb","rgxx","pp")]
[TestCase("rgyb","rgyx","ppp")]
[TestCase("rgyb","rgyb","pppp")]
[TestCase("rgyb","rgby","ppmm")]
[TestCase("rggg","rgyy","pp")]
[TestCase("rgxx","rggg","pp")]




	"rgyb","xxxx",""
	"rgyb","xxxr","m"
	"rgyb","xxgy","mm"
	"rgyb","xrgy","mmm"
	"rgyb","brgy","mmmm"
	"rgyb","rxxx","p"
	"rgyb","rgxx","pp"
	"rgyb","rgyx","ppp"
	"rgyb","rgyb","pppp"
	"rgyb","rgby","ppmm"
	"rggg","rgyy","pp"
	"rgxx","rggg","pp"




		public void testMarkingGuess(string secret, string guess, string result)
		{
			List<char> lSecret = secret.ToList();
			List<char> lGuess = guess.ToList();
			String cResult = result;
			Assert.AreEqual(result, MarkGuess.Guess(lGuess, lSecret));
		}

			


[TestCase("rgyb","xxxx","")]
[TestCase("rgyb","xxxr","m")]
[TestCase("rgyb","xxgy","mm")]
[TestCase("rgyb","xrgy","mmm")]
[TestCase("rgyb","brgy","mmmm")]
[TestCase("rgyb","rxxx","p")]
[TestCase("rgyb","rgxx","pp")]
[TestCase("rgyb","rgyx","ppp")]
[TestCase("rgyb","rgyb","pppp")]
[TestCase("rgyb","rgby","ppmm")]
[TestCase("rggg","rgyy","pp")]
[TestCase("rgXX","rggg","pp")]
		  

	/*
	[TestCase("a","x","")] // differnet color different position
	[TestCase("a-","xa","m")] // ok color wrong position
	[TestCase("a---","xxxa","m")] // ok color wrong position
	[TestCase("a---","axxx","p")] // ok color wrong position returns a p
	[TestCase("a---","aaxx","p")] // ok color wrong position and an extra returns a p
	[TestCase("aaaa","aaxx","pp")]
	[TestCase("aaba","aaxb","ppm")]
	[TestCase("aabb","bbaa","mmmm")]
 	public void test_mark_guess(string sSecret,string sGuess,string sResult)	
	{
		char[] secret=sSecret.ToCharArray();
		char[] guess=sGuess.ToCharArray();
		char[] result=sResult.ToCharArray();
		Assert.AreEqual(result,MarkGuess.guess(secret,guess));
	}

	*/

  }
}
	
		


