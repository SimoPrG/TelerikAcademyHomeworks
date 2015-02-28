//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Linq;
using System.Net.Mail;
using System.Text;


class ExtractEMails
{
    static void Main()
    {
        char[] separators = { ' ', ',', '\t', ':', ';', '-', '(', ')', '{', '}', '[', ']', '!', '?' };
        char[] trimmers = {'.','-','/','\\'};

        Console.WriteLine("Enter a text to extract emails from it:");
        string text = Console.ReadLine();
        string[] textArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).Where(x => IsEmailValid(x.Trim(trimmers))).ToArray();

        var emails = new StringBuilder();

        foreach (var email in textArr)
        {
            emails.AppendLine(email.Trim(trimmers));
        }
        if (emails.Length == 0)
        {
            emails.Append("There is no emails found!");
        }

        Console.WriteLine(emails);
    }

    static bool IsEmailValid(string text)
    {
        try
        {
            MailAddress m = new MailAddress(text);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}

