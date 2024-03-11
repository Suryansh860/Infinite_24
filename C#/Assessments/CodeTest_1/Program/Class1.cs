using System;
namespace std;

public class Class1
{
		static void main(string[] args)
		{
			Console.WriteLine(testcase("abcd"));
			Console.WriteLine(testcase("a"));
			Console.WriteLine(testcase("xy"));
			Console.ReadLine();
		}
		public static string testcase(string str1)
		{
			return string.Length > 1 ? str1.Substring(str1.Length - 1) + str1.Substring(1, str1.Length - 2) + str1.Substring(0, 1) : str1;
		}
	}
}
