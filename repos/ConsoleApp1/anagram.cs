using System;

public class Class1
{
	public static bool anagram(string str1, string str2)
	{
		string strs1 = str1.toLower();
        string strs2 = str2.toLower();

		char[] chars1 = strs1.toCharArray();
		char[] chars2 = strs2.toCharArray();

		if (chars1[] == chars2[])
		{
			return true;
		}
		return false;

    }

	static void Main(string[] args)
	{
		Console.WriteLine("enter string 1:");
		string str1 = Console.ReadLine();

        Console.WriteLine("enter string 2:");
        string str2 = Console.ReadLine();

		if(anagram(str1,str2))
		{
			Console.WriteLine("the strings are anagram");
		}
		else {
            Console.WriteLine("the strings are not anagram");
        }

		Console.ReadKey();
}
