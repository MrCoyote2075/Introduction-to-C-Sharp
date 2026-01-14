
// int n = 5;
Console.Write("Enter a number : ");
int n = int.Parse(Console.ReadLine());

// While Loop...
int k = 0;
while (++k <= n)
    Console.Write(k + " ");
Console.WriteLine();


// Do-While Loop...
k = n;
do 
    Console.Write(k + " "); 
while (--k > 0);
Console.WriteLine();


// Nested For Loop...
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("* ");
    Console.WriteLine();
}

// Foreach Loop...  
int[] arr = { 10, 20, 30, 40, 50 };

foreach (int num in arr)
    Console.Write(num + " ");
Console.WriteLine();

