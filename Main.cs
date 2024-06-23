using System;

namespace testOS;

public class Program {
	public static void Main(string[] args) {
		Console.WriteLine("\nWelcome to \x1b[96mtestOS\x1b[0m!\n");

		Shell.Start();
	}
}