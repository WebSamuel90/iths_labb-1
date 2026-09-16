string stringToCheck = "29535123p48723487597645723645";
long sum = 0;

for  (int i = 0; i < stringToCheck.Length; i++)
{
    if (!char.IsDigit(stringToCheck[i]))
    {
        continue;
    }

    // i and j could be used directly, but named positions improve readability
    int startPos = i;

    for (int j = startPos + 1; j < stringToCheck.Length; j++)
    {

        if (!char.IsDigit(stringToCheck[j]))
        {
            break;
        }


        if (stringToCheck[i] == stringToCheck[j])
        {
            int endPos = j;
            string substring = stringToCheck.Substring(startPos, endPos - startPos + 1);
            sum += long.Parse(substring);

            PrintSubstringWithColor(stringToCheck, startPos, endPos);

            Console.WriteLine();

            break;
        }
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Sum: {sum}");
Console.ResetColor();

static void PrintSubstringWithColor(string text, int startIndex, int endIndex)
{
    if (startIndex < 0 || endIndex >= text.Length || startIndex > endIndex)
    {
        return;
    }

    Console.Write(text.Substring(0, startIndex));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(text.Substring(startIndex, endIndex - startIndex + 1));
    Console.ResetColor();
    Console.Write(text.Substring(endIndex + 1));
}