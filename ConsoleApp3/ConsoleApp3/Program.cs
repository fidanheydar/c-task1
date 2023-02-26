int[] array = { 4, 67, 32, 51, 93 };
int enboyuk = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > enboyuk)
        enboyuk = array[i];


}
Console.WriteLine(enboyuk);


int[] array = { -5, 76, -81, -22, 8, 91, -52, 34, 41 };
int PositiveNumbers = 0;
int NegativeNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
        NegativeNumbers++;
    else if (array[i] > 0)
    {
        PositiveNumbers++;
    }
}
Console.WriteLine("Count of negative numbers: " + NegativeNumbers);
Console.WriteLine("Count of positive numbers: " + PositiveNumbers);



Console.WriteLine("Enter the exam result:");
int ExamScore = int.Parse(Console.ReadLine());

if (ExamScore >= 91 && ExamScore <= 100)
{
    Console.WriteLine("Your exam result is:A");
}

else if (ExamScore >= 81 && ExamScore <= 90)
{
    Console.WriteLine("Your exam result is:B");
}

else if (ExamScore >= 71 && ExamScore <= 80)
{
    Console.WriteLine("Your exam result is:C");
}

else if (ExamScore >= 61 && ExamScore <= 70)
{
    Console.WriteLine("Your exam result is:D");
}

else if (ExamScore >= 51 && ExamScore <= 60)
{
    Console.WriteLine("Your exam result is:E");
}

else if (ExamScore < 51)
{
    Console.WriteLine("You are failed");
}





