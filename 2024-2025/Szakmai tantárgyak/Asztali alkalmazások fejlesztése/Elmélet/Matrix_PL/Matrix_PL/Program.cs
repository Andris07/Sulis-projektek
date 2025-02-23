int[,] szamMatrix=MelysegBeolvasas();
int N = szamMatrix.GetLength(0);
int M = szamMatrix.GetLength(1);
Console.WriteLine("A beolvasott mátrix:");
SzamMatrixMegjelenites();
Console.WriteLine();
Console.WriteLine($"A mátrix elemeinek összege: {ElemekOsszege()}");
Console.WriteLine();
int[] sorOsszeg = SorOsszeg();
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"{i+1}. sor összege {sorOsszeg[i]}");
}
Console.WriteLine();
int[] oszlopOsszeg = OszlopOsszeg();
for (int j = 0; j < M; j++)
{
    Console.WriteLine($"{j + 1}. oszlop összege {oszlopOsszeg[j]}");
}
Console.WriteLine();
int maximumHelyX, maximumHelyY;
MaximumHely(out maximumHelyX, out maximumHelyY);
Console.WriteLine($"A legnagyobb érték a {maximumHelyX + 1}. sor {maximumHelyY + 1}. oszlop eleme: " +
    $"{szamMatrix[maximumHelyX, maximumHelyY]}");
Console.WriteLine();

int N_char = 15; //sorok száma
int M_char = 20; //oszlopok száma
char[,] karakterMatrix = new char[N_char, M_char];
SzabadBeolvasas();
Console.WriteLine("A karakter mátrix:");
KarakterMatrixMegjelenites();

int[,] MelysegBeolvasas()
{
    string[] adatSorok = File.ReadAllLines("melyseg.txt");
    int N = int.Parse(adatSorok[0]);
    int M = int.Parse((adatSorok[1]));
    int[,] matrix = new int[N, M];
    for (int i = 0; i < N; i++)
    {
        string[] ertekek = adatSorok[i + 2].Split();
        for (int j = 0; j < M; j++)
        {
            matrix[i, j] = int.Parse(ertekek[j]);
        }
    }
    return matrix;
}

void SzamMatrixMegjelenites()
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            Console.Write($"{szamMatrix[i,j], 3}");
        }
        Console.WriteLine();
    }
}

int ElemekOsszege()
{
    int osszeg = 0;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            osszeg += szamMatrix[i, j];
        }
    }
    return osszeg;
}

int[] SorOsszeg()
{
    int[] sorOsszeg = new int[N];
    for (int i = 0; i < N; i++)
    {
        int osszeg = 0;
        for (int j = 0; j < M; j++)
        {
            osszeg += szamMatrix[i, j];
        }
        sorOsszeg[i] = osszeg; 
    }
    return sorOsszeg;
}

int[] OszlopOsszeg()
{
    int[] oszlopOsszeg = new int[M];
    for (int j = 0; j < M; j++)
    {
        int osszeg = 0;
        for (int i = 0; i < N; i++)
        {
            osszeg += szamMatrix[i, j];
        }
        oszlopOsszeg[j] = osszeg;
    }
    return oszlopOsszeg;
}

void MaximumHely(out int maxX, out int maxY)
{
    maxX = 0;
    maxY = 0;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (szamMatrix[i, j] > szamMatrix[maxX, maxY])
            {
                maxX = i;
                maxY = j;
            }
        }
    }
}

void SzabadBeolvasas()
{
    string[] sorok = File.ReadAllLines("szabad.txt");
    for (int i = 0; i < N_char; i++)
    {
        for (int j = 0; j < M_char; j++)
        {
            karakterMatrix[i, j] = sorok[i][j];
        }
    }
}

void KarakterMatrixMegjelenites()
{
    for (int i = 0; i < N_char; i++)
    {
        for (int j = 0; j < M_char; j++)
        {
            Console.Write($"{karakterMatrix[i, j]} ");
        }
        Console.WriteLine();
    }

}