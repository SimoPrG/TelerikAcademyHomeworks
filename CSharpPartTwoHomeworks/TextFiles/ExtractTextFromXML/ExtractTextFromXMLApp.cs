//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"?><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest>
//<interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.IO;
using System.Xml;

class ExtractTextFromXMLApp
{
    static void Main()
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\input.xml");
            string xmlcontents = doc.InnerText;
            Console.WriteLine(xmlcontents);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}

