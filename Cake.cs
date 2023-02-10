
using System;
using System.Linq;

public static class Module {    
    public static int numberOfTeaSpoonsToMakeCakeTooSweet(int n) {
        int x = 0;
        foreach (var i in Enumerable.Range(1, n + 1 - 1)[: - 1:]) {
            var isCakeTooSweet = isTooSweet(i);
            if (isCakeTooSweet) {
                x += 1;
            } else {
                return x;
            }
        }
    }

    static void Main()
	{
		Console.WriteLine("Enter a number to get the number of tea spoons: ");
		int N = int.Parse(Console.ReadLine());
		numberOfTeaSpoonsToMakeCakeTooSweet(N);
	}
}

