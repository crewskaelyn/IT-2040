using System;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anotherDoc = true;
            string file;

            while(anotherDoc) {
                Console.WriteLine("Document\n");
                file = fileName();

                fileContents(file);

                Console.WriteLine("\nWould you like to write another file? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer != "y") {
                    anotherDoc = false;
                }
            }
        }

        static string fileName() {
            string name = "";
            Console.WriteLine("Enter the name of the document:");
            try {
                name = Console.ReadLine();
            } catch(Exception x) {
                Console.WriteLine("Exception: " + x.Message);
            }

            if (name.EndsWith(".txt")) {
                return name;
            } else {
                return name + ".txt";
            }
        }

        static void fileContents(string name) {
            StreamWriter write = File.AppendText(name);

            Console.WriteLine("\nEnter the content for the document:");
            string content = Console.ReadLine();

            try {
                write.WriteLine(content);
            } catch(Exception x) {
                Console.WriteLine("Exception: " + x.Message);
            } finally {
                write.Close();
                Console.WriteLine($"\n{name} was successfully saved. The document contains {content.Length} characters.");
            }
        }
        

    }
}