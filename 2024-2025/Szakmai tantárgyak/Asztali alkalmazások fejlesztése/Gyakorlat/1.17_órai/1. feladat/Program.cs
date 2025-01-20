Random r = new Random();
Console.WriteLine("Mátrixok feladat");

// 1. feladat
Console.WriteLine("1. feladat");
Console.Write("Kérem adja meg a mátrix első dimenzióját: ");
int intmatrix_n = int.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a mátrix második dimenzióját: ");
int intmatrix_m = int.Parse(Console.ReadLine());
int[,] intmatrix = new int[intmatrix_n, intmatrix_m];

Console.WriteLine();
for (int i = 0; i < intmatrix_n; i++)
{
    for (int j = 0; j < intmatrix_m; j++)
    {
        intmatrix[i, j] = r.Next(101);
        Console.Write($"{intmatrix[i, j],4} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 2. feladat
Console.WriteLine("2. feladat");
string[,] stringmatrix = {{"Andris", "Bálint", "Péter"}, {"Botond", "Dániel", "Donát"}, {"Ágoston", "Dominik", "Zsombor"}};

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"{i+1}. sor {j+1}. elem: {stringmatrix[i, j]}");
    }
}
Console.WriteLine();

// 3. feladat
Console.WriteLine("3. feladat");
int[][] intjagged = new int[6][];

for (int i = 0; i < 6; i++)
{
    intjagged[i] = new int[r.Next(3, 10)];
    for (int j = 0; j < intjagged[i].Length; j++)
    {
        intjagged[i][j] = r.Next(10);
        Console.Write($"{intjagged[i][j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 4. feladat
Console.WriteLine("4. feladat");
int[][] intjagged_inc = new int[][]
{
    new int[] {intjagged[0][0], intjagged[0][1], intjagged[0][2]},
    new int[] {intjagged[1][0], intjagged[1][1], intjagged[1][2]},
    new int[] {intjagged[2][0], intjagged[2][1], intjagged[2][2]},
    new int[] {intjagged[3][0], intjagged[3][1], intjagged[3][2]},
    new int[] {intjagged[4][0], intjagged[4][1], intjagged[4][2]},
    new int[] {intjagged[5][0], intjagged[5][1], intjagged[5][2] }
};

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < intjagged_inc[i].Length; j++)
    {
        Console.Write($"{intjagged_inc[i][j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 5. feladat
Console.WriteLine("5. feladat");
Console.Write("Kérem adja meg az n*n-es mátrix méretét: ");
int n = int.Parse(Console.ReadLine());
int[,] egysegmatrix = new int[n,n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            egysegmatrix[i, j] = 1;
        }
        else
        {
            egysegmatrix[i, j] = 0;
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{egysegmatrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 6. feladat
Console.WriteLine("6. feladat");
Console.Write("Kérem adja meg a mátrix első dimenzióját: ");
int intmatrix2_n = int.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a mátrix második dimenzióját: ");
int intmatrix2_m = int.Parse(Console.ReadLine());
int[,] intmatrix2 = new int[intmatrix2_n, intmatrix2_m];

int szam = 0;
for (int i = 0; i < intmatrix2_n; i++)
{
    for (int j = 0; j < intmatrix2_m; j++)
    {
        intmatrix2[i, j] = szam;
        szam++;
    }
}
Console.WriteLine();

for (int i = 0; i < intmatrix2_n; i++)
{
    for (int j = 0; j < intmatrix2_m; j++)
    {
        Console.Write($"{intmatrix2[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 7. feladat
Console.WriteLine("7. feladat");
Console.Write("Kérem adja meg az n*n-es mátrix méretét: ");
int matrix_n = int.Parse(Console.ReadLine());
int[,] matrix = new int[matrix_n, matrix_n];

// 7. a feladat
Console.WriteLine();
Console.WriteLine("7. a feladat");
for (int i = 0; i < matrix_n; i++)
{
    for (int j = 0; j < matrix_n; j++)
    {
        matrix[i, j] = r.Next(101);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 7. b feladat
Console.WriteLine("7. b feladat");
for (int i = 0; i < matrix_n; i++)
{
    Console.Write($"{matrix[i, i]} ");
}
Console.WriteLine("\n");

// 7. c feladat
Console.WriteLine("7. c feladat");
for (int i = 0; i < matrix_n; i++)
{
    Console.Write($"{matrix[i, matrix_n-1-i]} ");
}
Console.WriteLine("\n");

// 7. d feladat
Console.WriteLine("7. d feladat");
for (int i = 0; i < matrix_n; i++)
{
    for (int j = i + 1; j < matrix_n; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
}
Console.WriteLine("\n");

// 7. e feladat
Console.WriteLine("7. e feladat");
for (int i = 1; i < matrix_n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
}
Console.WriteLine("\n");

// 7. f feladat
Console.WriteLine("7. f feladat");
for (int i = 0; i < matrix_n - 1; i++)
{
    for (int j = 0; j < matrix_n-1-i; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
}
Console.WriteLine("\n");

// 7. g feladat
Console.WriteLine("7. g feladat");
for (int i = 1; i < matrix_n; i++)
{
    for (int j = matrix_n - i; j < matrix_n; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
}
Console.WriteLine();