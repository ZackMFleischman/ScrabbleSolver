using System;
using System.IO;

// This program should output all valid Scrabble words formed from the 7 letters given as input.
//
// The 7 letters will be provided as a single string as the first command line parameter.
// They are in the range [a-z] and can be assumed to be valid input (always 7, and always lowercase letters from 'a' to 'z') 
class ScrabbleSolver {
    static void Main(string[] args) {
        string letters = args[0];
        string[] allScrabbleWords = File.ReadAllLines("ScrabbleDictionary.txt");
        
        string[] validScrabbleWordsFormedWithLetters = GetValidScrabbleWordsFromLetters(letters, allScrabbleWords);
        DumpValidScrabbleWordsToConsole(validScrabbleWordsFormedWithLetters, letters);
    }

    static void DumpValidScrabbleWordsToConsole(string[] scrabbleWords, string lettersUsed) {
        Console.WriteLine($"Found {scrabbleWords.Length} valid Scrabble words formed with the letters '{lettersUsed}':");
        foreach (string word in scrabbleWords)
            Console.WriteLine(word);
    }

    //
    // Please implement this function.
    //
    static string[] GetValidScrabbleWordsFromLetters(string letters, string[] allScrabbleWords) {
        return new string[0];
    }
}