using System;
using System.IO;
using System.Text;

public class FileReader
{
    public static string[][] EmptyToFull(string[][] AA)
    {
        int[] k = new int[AA.Length];
        int r = AA.Length;
        for (int i = 0; i < AA.Length; i++)
        {
            k[i] = 0;
            for (int j = 0; j < AA[i].Length; j++)
            {
                if (AA[i][j] != "")
                {
                    k[i]++;
                }
            }
            if (k[i] == 0)
            {
                r--;
            }
        }

        string[][] AA2 = new string[r][];
        int y = 0;
        for (int i = 0; i < r; i++)
        {
            if (k[i] != 0)
            {
                AA2[y] = new string[k[i]];
                int x = 0;
                for (int j = 0; j < AA[i].Length; j++)
                {
                    if (AA[i][j] != "")
                    {
                        AA2[y][x] = AA[i][j];
                        x++;
                    }
                }
                y++;
            }
        }
        return AA2;
    }
    public static void IsEmpty (string[][] ar)
    {
        bool empty = false;
        int s = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = 0; j < ar[i].Length; j++)
            {
                if (ar[i][j] == "")
                {
                    s++;
                    empty = true;
                }
            }
        }
        if (empty)
        {
            Console.WriteLine("Уберите {0} лишних пробела(-ов)", s);
        }
    }
    public static void IsEmpty (string[][] ar, out bool b)
    {
        bool empty = false;
        int s = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = 0; j < ar[i].Length; j++)
            {
                if (ar[i][j] == "")
                {
                    s++;
                    empty = true;
                }
            }
        }
        if (empty)
        {
            Console.WriteLine("Уберите {0} лишних пробела(-ов)", s);
        }
        b = empty;
    }
    public static bool IsMat(string[][] ar)
    {
        bool b;
        if (ar.Length > 1)
        {
            int i = 0;
            do
            {
                b = ar[i].Length == ar[++i].Length;
            }
            while (b & (i < (ar.Length - 1)));
        }
        else
        {
            b = true;
        }
        return b;
    }
    public static string[][] ArrayOfArray(char wall, string path)
	{
        try
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Происходит чтение файла {0}", path);
            Console.ForegroundColor = ConsoleColor.Gray;
            string[] ArrayOfFile = File.ReadAllLines(path, Encoding.Default);
            string[][] LineArray = new string[ArrayOfFile.Length][];
            for (int i = 0; i < ArrayOfFile.Length; i++)
            {
                LineArray[i] = ArrayOfFile[i].Split(new char[] { wall });
            }
            return LineArray;
        }
        catch (FileNotFoundException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\aФайла {0} не существует", path);
            Console.ForegroundColor = ConsoleColor.Gray;
            return null;
        }
    }
    public static string[][] ArrayOfArray(string path, char wall)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Происходит чтение файла {0}", path);
            Console.ForegroundColor = ConsoleColor.Gray;
            string[] ArrayOfFile = File.ReadAllLines(path, Encoding.Default);
            string[][] LineArray = new string[ArrayOfFile.Length][];
            for (int i = 0; i < ArrayOfFile.Length; i++)
            {
                LineArray[i] = ArrayOfFile[i].Split(new char[] { wall });
            }
            string[][] LineArray2 = EmptyToFull(LineArray);
            return LineArray2;
        }
        catch (FileNotFoundException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\aФайла {0} не существует", path);
            Console.ForegroundColor = ConsoleColor.Gray;
            return null;
        }
    }
    public static string[,] Matrix(string path, char wall)
    {
        string[][] ar = ArrayOfArray(path, wall);
        if (IsMat(ar))
        {
            int m = ar.Length;
            int n = ar[0].Length;
            string[,] mat = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = ar[j][i];
                }
            }
            IsEmpty(ar);
            return mat;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\aЭто массив массивов с разным к-твом элементов в строках.");
            IsEmpty(ar);
            Console.ForegroundColor = ConsoleColor.Gray;
            return null;
        }
    }
    public static string[][] StringAA(string path)
    {
        string[][] arr = ArrayOfArray(path, ' ');
        return arr;
    }
    public static int[][] IntAA(string path)
    {
        string[][] aas = ArrayOfArray(path, ' ');
        bool b;
        int n = aas.Length;
        int[][] arr = new int[n][];
        for (int i = 0; i < n; i++)
        {
            arr[i] = new int[aas[i].Length];
            for (int j = 0; j < aas[i].Length; j++)
            {
                try
                {
                    arr[i][j] = int.Parse(aas[i][j]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат элемента [0][1]", i, j);

                    // Input.Int("Проверьте файл и введите корректное значение: ");
                }
            }
        }            
        return arr;
    }
    public static decimal[][] DecimalAA(string path)
    {
        string[][] aas = ArrayOfArray(path, ' ');
        int n = aas.Length;
        decimal[][] arr = new decimal[n][];
        for (int j = 0; j < n; j++)
        {
            arr[j] = new decimal[aas[j].Length];
            for (int i = 0; i < aas[j].Length; i++)
            {
                bool flag;
                string el = aas[j][i];
                arr[j][i] = Input.Exeption4Decimal(ref aas[j][i], out flag);
                aas[j][i] = el;
                if (!flag)
                {
                    Console.Write("Неверный формат у числа {0}, введите корректный формат числа: ", aas[j][i]);
                    arr[j][i] = Input.Decimal("");
                }
            }
        }
        return arr;
    }
    public static double[][] DoubleAA(string path)
    {
        string[][] aas = ArrayOfArray(path, ' ');
        int n = aas.Length;
        double[][] arr = new double[n][];
        for (int j = 0; j < n; j++)
        {
            arr[j] = new double[aas[j].Length];
            for (int i = 0; i < aas[j].Length; i++)
            {
                bool flag;
                string el = aas[j][i];
                arr[j][i] = Input.Exeption4Double(ref aas[j][i], out flag);
                aas[j][i] = el;
                if (!flag)
                {
                    Console.Write("Неверный формат у числа {0}, введите корректный формат числа: ", aas[j][i]);
                    arr[j][i] = Input.Double("");
                }
            }
        }
        return arr;
    }
    public static float[][] FloatAA(string path)
    {
        string[][] aas = ArrayOfArray(path, ' ');
        int n = aas.Length;
        float[][] arr = new float[n][];
        for (int j = 0; j < n; j++)
        {
            arr[j] = new float[aas[j].Length];
            for (int i = 0; i < aas[j].Length; i++)
            {
                bool flag;
                string el = aas[j][i];
                arr[j][i] = Input.Exeption4Float(ref aas[j][i], out flag);
                aas[j][i] = el;
                if (!flag)
                {
                    Console.Write("Неверный формат у числа {0}, введите корректный формат числа: ", aas[j][i]);
                    arr[j][i] = Input.Float("");
                }
            }
        }
        return arr;
    }
    public static double[,] DoubleMatrix(string path)
    {
        char wall = ' ';
        string[,] SMat = Matrix(path, wall);
        int x = SMat.GetLength(0);
        int y = SMat.GetLength(1);
        bool b;
        string read;
        double[,] Mat = new double[x, y];
        for(int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                read = SMat[i, j];
                Mat[i,j] = Input.Exeption4Double(ref read, out b);
                if (!b)
                {
                    Console.Write("\aНеверное значение для числа {0}, введите корректное значение: ", SMat[i, j]);
                    Mat[i, j] = Input.Double("");
                }
            }
        }
        return Mat;
    }
}
