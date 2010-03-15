using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace kata {
		public class MarkGuess
		{
				private static bool Contains(List<char> values, char value)
				{
						if (values.Contains(value))
						{
								values.Remove(value);
								return true;
						}
						return false;
								
				}
				public static string Guess(List<char>secret, List<char> guess)
				{
						int index=0;
						string okLettOkPos=	guess.Aggregate("",(x,y)=> x+=(secret[index++]==y?"p":""));
						string okLettWrongPos=	 guess.Aggregate("",(x,y)=> x+=(Contains(secret,y)?"m":""));
						string toReturn = okLettOkPos+okLettWrongPos;
						toReturn = toReturn.Substring(0,toReturn.Length-okLettOkPos.Length);
						return toReturn;
				}
						
		}
}

