using System;

class Program {

    public static void Main(string[] args) {

        // ToUpper
        string str1 = "digital technology";
        Console.WriteLine( str1.ToUpper() );

        // ToLower
        string str2 = "SOFTWARE SYSTEMS DEVELOPMENT";
        Console.WriteLine( str2.ToLower() );

        // Length
        string str3 = "Coulter";
        Console.WriteLine( str3.Length );

        // Checking for null
        string TestOne = "";
        Console.WriteLine( string.IsNullOrEmpty(TestOne) );

        string TestTwo = " ";
        Console.WriteLine( string.IsNullOrEmpty(TestTwo) );

        string TestThree = "Hello, World!";
        Console.WriteLine( string.IsNullOrEmpty(TestThree) );

        string TestFour = null;
        Console.WriteLine( string.IsNullOrEmpty(TestFour) );

        // Split
        string str4 = "Hello, how are you?";
        string str5 = str4.Split(' ');
        Console.WriteLine(str5);

    }
}