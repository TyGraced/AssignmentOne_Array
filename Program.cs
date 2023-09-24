class Program
{
    static void Main(string[] args)
    {
        int[] input1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int ouput1 = CalculateScore(input1);
        Console.WriteLine($"Input: [{string.Join(", ", input1)}]\nOutput: {ouput1}");

        int[] input2 = { 13, 15, 21, 25, 35, 37 };
        int ouput2 = CalculateScore(input2);
        Console.WriteLine($"Input: [{string.Join(", ", input2)}]\nOutput: {ouput2}");

        int[] input3 = { 13, 8, 21, 8, 35, 8, 2 };
        int ouput3 = CalculateScore(input3);
        Console.WriteLine($"Input: [{string.Join(", ", input3)}]\nOutput: {ouput3}");

        int[] input4 = { 2, 4, 6, 10, 12 };
        int ouput4 = CalculateScore(input4);
        Console.WriteLine($"Input: [{string.Join(", ", input4)}]\nOutput: {ouput4}");

        int[] input5 = {  8, 8, 8, 8, 8, 8 };
        int ouput5 = CalculateScore(input5);
        Console.WriteLine($"Input: [{string.Join(", ", input5)}]\nOutput: {ouput5}");
    }

    static int CalculateScore(int[] array)
    {
        int score = 0;

        foreach (int i in array) 
        { 
            if (i % 2 == 0)
            {
                score += 1; // Add 1 point for every even number.
            }
            else
            {
                score += 3; // Add 3 points for every odd number.
            }

            if (i == 8)
            {
                score += 5; // Add 5 points for every number 8
            }
        }

        return score;
    }
}