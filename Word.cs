using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyTest
{
    public class Word
    {
        private string _Words;
        public Word(string word)
        {
            _Words = word;
        }
        /// <summary>
        /// Reverse the word 
        /// </summary>
        /// <returns></returns>
        public string Reverse()
        {

            if (_Words == null)
                return "";
            var reverseWord = string.Join(" ",
            _Words.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            return reverseWord;
        }

    }
}