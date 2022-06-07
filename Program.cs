using System.Linq;

string str = "1 2 3"; 
string minAndMax = Kata.HighAndLow(str);
Console.WriteLine(minAndMax);

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        string [] arrayStrinAfterSplit=numbers.Split(' ');
        int[] arrayOfNumber = new int[arrayStrinAfterSplit.Length];
        for (int i = 0; i < arrayStrinAfterSplit.Length; i++)
        {
            arrayOfNumber[i] = Int32.Parse(arrayStrinAfterSplit[i]);
        }
        int min = arrayOfNumber[0];
        int max = arrayOfNumber[0];
        for (int i = 0; i < arrayOfNumber.Length; i++)
        {
            if (min > arrayOfNumber[i]) min = arrayOfNumber[i];
            if (max < arrayOfNumber[i]) max = arrayOfNumber[i];
        }
        string result = $"{max} {min}";
        return result;
    }
}