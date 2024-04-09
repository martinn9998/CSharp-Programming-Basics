string textn1 = Console.ReadLine();
int n1 = int.Parse(textn1);
string textn2 = Console.ReadLine();
int n2 = int.Parse(textn2);
int evenSum = 0;
int oddSum = 0;
char letter = ' ';
if (n1<n2)
{
    for (int a = n1; a <= n2; a++)
    {
        string number = a.ToString();
        for (int i = 0; i < number.Length; i++)
        {
            letter = number[i];
            if (i % 2 == 1) // odd
            {
                int charToInt = letter - '0';
                evenSum += charToInt;
            }
            else if (i % 2 == 0)
            {
                int charToInt = letter - '0';
                oddSum += charToInt;
            }
        }
        if (oddSum == evenSum)
        {
            Console.Write($"{a} ");
         
        }
        oddSum = 0;
        evenSum = 0;
        
    }
}    
