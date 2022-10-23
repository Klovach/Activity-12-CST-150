using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;

public class Activity12
{
    public static void Main()
    {
        //Intialize variables. 
        int letter = 0;
        int wordCount = 0;


        // Open the file. 
            string str = System.IO.File.ReadAllText("sample.txt");
        // Display the string to the user. 
            Console.WriteLine(str);
        // Invoke the RemovePunctuation Method. 
            str = str.RemovePunctuation();


        /* Here, after we have stripped the string of its punctuation, 
         * we check if the last letter following a space is t or e.*/
        while (letter <= str.Length - 1)
        {

            if ((str[letter] == ' ') && (str[letter - 1] == 't' || str[letter - 1] == 'e'))
            {
                wordCount++;
            }
            letter++;
        }
        Console.WriteLine("There are " + wordCount + " words that end in t or e.");
    }
}


// StringBuilding class. 
public static class StringBuilding
{
    /*Here we have a RemovePunctuation method we will use to strip the punctuation from our string.
    * If the character is not punctuation, it is appended to a string. The spaces are important
     * for us to identify the end of a word, so we place spaces in place of missing punctuation marks. */
    public static string RemovePunctuation(this string str)
    {
        var sb = new StringBuilder();
        foreach (char c in str)
        {
            if (char.IsPunctuation(c))
                sb.Append(' ');
            if (!char.IsPunctuation(c))
                sb.Append(c);
        }
        return sb.ToString();
    }
}