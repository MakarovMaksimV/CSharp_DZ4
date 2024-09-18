namespace DZ4;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 7, 5, 1, 3, 2, 5, 8, 2, 4, 5, 6, 9, 0, 12, 65, 7, 23 };
        Number number = new Number();
        number.isNumber(arr);
    }
}

