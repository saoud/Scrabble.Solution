using System;
using System.Collections.Generic;


namespace Scrabble
{
	public class Logic
	{
        public static bool BigWordBonus (string inputWord) {
            int wordLength = inputWord.Length;
            Console.Write(wordLength);
            if (wordLength >= 7) {
            return true;
            } else return false;
         }
	}
}

// 1. Find length of string.
// 2. Use conditional to determine if length is > 7.
// 3. If length is greater then 7, return true. 

