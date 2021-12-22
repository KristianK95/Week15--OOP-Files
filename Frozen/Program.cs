using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Wish
        {
            string name;
            string wish;


            public Wish(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }

            //getters for movie

            public string Title
            {
                get { return name; }
            }
            public string Rating
            {
                get { return wish; }
            }
            static void Main(string[] args)
            {
                //Anna wants new earrings for Christmas
                List<Wish> myWish = new List<Wish>();
                string[] wishesFromFile = GetDataFromFile();

                foreach (string line in wishesFromFile)
                {
                    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    Wish newWish = new Wish(tempArray[0], tempArray[1]);
                    myWish.Add(newWish);
                }

                foreach (Wish wishFromList in myWish)
                {
                    Console.WriteLine($"{wishFromList.name} wants {wishFromList.wish} for Christmas.");
                }

            }

            public static void DisplayElementsFromArray(string[] someArray)
            {
                foreach (string element in someArray)
                {
                    Console.WriteLine($"String from array: {element}");
                }
            }
            public static string[] GetDataFromFile()
            {
                string filePath = @"C:\Users\Kristian\Desktop\frozen.txt";
                string[] dataFromFile = File.ReadAllLines(filePath);

                return dataFromFile;
            }
        }

    }

}