//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFileContentsApp
{
    static void Main()
    {
        try
        {
            Console.WriteLine(@"Enter full file path (e.g C:\WINDOWS\win.ini): ");
            string path = Console.ReadLine(); ;
            var read = File.ReadAllText(path);
            Console.WriteLine(read);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Wrong path!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Undefined error!");
        }
    }
}

