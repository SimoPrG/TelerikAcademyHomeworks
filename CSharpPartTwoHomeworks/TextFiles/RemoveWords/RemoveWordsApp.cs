//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Linq;

class RemoveWordsApp
{
    static void Main()
    {
        try
        {
            string result = string.Empty;
            using (var fileOne = new StreamReader(@"..\..\words.txt"))
            {
                string words = fileOne.ReadToEnd();
                words = words.ToLower();
                string forbidWords = string.Empty;
                using (var fileTwo = new StreamReader(@"..\..\forbidWords.txt"))
                {
                    forbidWords = fileTwo.ReadToEnd();
                    forbidWords = forbidWords.ToLower();
                }
                string[] arr = words.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => !forbidWords.Contains(x)).ToArray();
                result = string.Join(" ", arr);
            }

            using (var output = new StreamWriter(@"..\..\words.txt"))
            {
                output.WriteLine(result);
            }
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

