using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2Demo
{
    class Program
    {
        static Random letterGenerate = new Random();
        static void Main(string[] args)
        {
            string[] names = { "Bort", "Arya", "Curt", "Eden", "Fred", "Gina", "Jack", "Kate" };
            char[] pets = "dog cat hamster parrot buggie spider rabbit snake".ToCharArray();
            #region Demo 1-A
            //Console.WriteLine("Original names: ");
            //PrintStringArray(names);

            //Console.WriteLine("\nReversed names: ");
            //Array.Reverse(names);
            //PrintStringArray(names);

            //Console.WriteLine("\nSorted names: ");
            //Array.Sort(names);
            //PrintStringArray(names);

            //Console.WriteLine();

            //string toFind = "Bort";
            //Console.WriteLine($"\nSearching for {toFind}");
            //int position = Array.BinarySearch(names, toFind);
            //Console.WriteLine($"{toFind} was located at {position}.");
            #endregion

            #region Demo 1-B
            //Console.WriteLine("Original names: ");
            //PrintCharArray(pets);

            //Console.WriteLine("\nReversed names: ");
            //Array.Reverse(pets);
            //PrintCharArray(pets);

            //Console.WriteLine("\nSorted names: ");
            //Array.Sort(pets);
            //PrintCharArray(pets);

            //Console.WriteLine();

            //char toFind = 'a';
            //Console.WriteLine($"\nSearching for {toFind}");
            //int position = Array.BinarySearch(pets, toFind);
            //Console.WriteLine($"{toFind} was located at {position}.");
            #endregion

            #region Demo 1-C
            //Console.WriteLine(CreateWord(5));

            string[] sentencez = CreateWordArray(6, 10);
            PrintStringArray(sentencez);
            #endregion
        }

        static void PrintStringArray(string[] toPrint)
        {
            foreach (string name in toPrint)
            {
                Console.WriteLine($"{name}");
            }
        }

        static void PrintCharArray (char[] toPrint)
        {
            foreach (char letter in toPrint)
            {
                Console.Write($"{letter}");
            }
        }

        static string CreateWord(int numberOfLetters)
        {
            string word = "";
            for (int i = 0; i < numberOfLetters; i++)
            {
                word += (char)letterGenerate.Next('a', 'z');
                
            }

            return word;
        }

        static string[] CreateWordArray(int wordSize, int numberOfWords)
        {
            string[] result = new string[numberOfWords];

            for (int i = 0; i < numberOfWords; i++)
            {
                result[i] = CreateWord(wordSize);

            }
            return result;
        }
    }
}
