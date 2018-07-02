using System;
using System.IO;

class ScrabbleSolver {
    static void Main(string[] args) {
        string letters = args[0]; // You may assume this is a string of 7 characters in the range [a-z].
        string[] allScrabbleWords = _LoadScrabbleDictionary();
        
        string[] validScrabbleWordsFormedWithLetters = _GetValidScrabbleWordsFromLetters(letters, allScrabbleWords);

        _DumpValidScrabbleWordsToConsole(validScrabbleWordsFormedWithLetters, letters);
    }

    static string[] _LoadScrabbleDictionary() => File.ReadAllLines("ScrabbleDictionary.txt");

    static void _DumpValidScrabbleWordsToConsole(string[] scrabbleWords, string lettersUsed) {
        Console.WriteLine($"Found {scrabbleWords.Length} valid Scrabble words formed with the letters '{lettersUsed}':");
        foreach (string word in scrabbleWords)
            Console.WriteLine(word);
    }

    
    //
    // Please implement this function.
    //
    static string[] _GetValidScrabbleWordsFromLetters(string letters, string[] allScrabbleWords) {
        return new string[0];
    }
}