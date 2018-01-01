using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class FileWriter
{
    public static void StringNew(string path, string read)
    {
        File.WriteAllText(path, read);
    }
    public static void StringLine(string path, string line)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        sw.WriteLine(line);
        sw.Close();
    }
    public static void AALine(string path, string[][] AA)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.Length; i++)
        {
            for (int j = 0; j < AA[i].Length; j++)
            {
                AA2[i] = AA2[i] + AA[i][j] + " ";
            }
            sw.WriteLine(AA2[i]);
        }
        sw.Close();
    }
    public static void AANew(string path, string[][] AA)
    {
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.Length; i++)
        {
            for (int j = 0; j < AA[i].Length; j++)
            {
                AA2[i] = AA2[i] + AA[i][j] + " ";
            }
        }
        File.WriteAllLines(path, AA2, Encoding.Default);
    }
    public static void MatLine(string path, string[,] AA)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.GetLength(1); i++)
        {
            for (int j = 0; j < AA.GetLength(1); j++)
            {
                AA2[i] = AA2[i] + AA[i, j] + " ";
            }
            sw.WriteLine(AA2[i]);
        }
        sw.Close();
    }
    public static void MatNew(string path, string[,] AA)
    {
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.GetLength(1); i++)
        {
            for (int j = 0; j < AA.GetLength(1); j++)
            {
                AA2[i] = AA2[i] + AA[i,j] + " ";
            }
        }
        File.WriteAllLines(path, AA2, Encoding.Default);
    }
    public static void ArrLine(string path, string[] AA)
    {
        string AS = "";
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        for (int i = 0; i < AA.Length; i++)
        {
            AS = AS + AA[i] + " ";
        }
        sw.WriteLine(AS);
        sw.Close();
    }
    public static void ArrNew(string path, string[] AA)
    {
        string AS = "";
        for (int i = 0; i < AA.Length; i++)
        {
            AS = AS + AA[i] + " ";
        }
        File.WriteAllText(path, AS);
    }
    public static void StringNew(string path, double read)
    {
        string str = Convert.ToString(read);
        File.WriteAllText(path, str);
    }
    public static void StringLine(string path, double line)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        sw.WriteLine(line);
        sw.Close();
    }
    public static void AALine(string path, double[][] AA)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.Length; i++)
        {
            for (int j = 0; j < AA[i].Length; j++)
            {
                AA2[i] = AA2[i] + AA[i][j] + " ";
            }
            sw.WriteLine(AA2[i]);
        }
        sw.Close();
    }
    public static void AANew(string path, double[][] AA)
    {
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.Length; i++)
        {
            for (int j = 0; j < AA[i].Length; j++)
            {
                AA2[i] = AA2[i] + AA[i][j] + " ";
            }
        }
        File.WriteAllLines(path, AA2, Encoding.Default);
    }
    public static void MatLine(string path, double[,] AA)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.GetLength(1); i++)
        {
            for (int j = 0; j < AA.GetLength(1); j++)
            {
                AA2[i] = AA2[i] + AA[i, j] + " ";
            }
            sw.WriteLine(AA2[i]);
        }
        sw.Close();
    }
    public static void MatNew(string path, double[,] AA)
    {
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.GetLength(0); i++)
        {
            for (int j = 0; j < AA.GetLength(1); j++)
            {
                AA2[i] = AA2[i] + AA[i, j] + " ";
            }
        }
        File.WriteAllLines(path, AA2, Encoding.Default);
    }
    public static void ArrLine(string path, double[] AA)
    {
        string AS = "";
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        for (int i = 0; i < AA.Length; i++)
        {
            AS = AS + AA[i] + " ";
        }
        sw.WriteLine(AS);
        sw.Close();
    }
    public static void ArrNew(string path, double[] AA)
    {
        string AS = "";
        for (int i = 0; i < AA.Length; i++)
        {
            AS = AS + AA[i] + " ";
        }
        File.WriteAllText(path, AS);
    }
    public static void StringNew(string path, float read)
    {
        string str = Convert.ToString(read);
        File.WriteAllText(path, str);
    }
    public static void StringLine(string path, float line)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        sw.WriteLine(line);
        sw.Close();
    }
    public static void AALine(string path, float[][] AA)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.Length; i++)
        {
            for (int j = 0; j < AA[i].Length; j++)
            {
                AA2[i] = AA2[i] + AA[i][j] + " ";
            }
            sw.WriteLine(AA2[i]);
        }
        sw.Close();
    }
    public static void AANew(string path, float[][] AA)
    {
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.Length; i++)
        {
            for (int j = 0; j < AA[i].Length; j++)
            {
                AA2[i] = AA2[i] + AA[i][j] + " ";
            }
        }
        File.WriteAllLines(path, AA2, Encoding.Default);
    }
    public static void MatLine(string path, float[,] AA)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.GetLength(1); i++)
        {
            for (int j = 0; j < AA.GetLength(1); j++)
            {
                AA2[i] = AA2[i] + AA[i, j] + " ";
            }
            sw.WriteLine(AA2[i]);
        }
        sw.Close();
    }
    public static void MatNew(string path, float[,] AA)
    {
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.GetLength(1); i++)
        {
            for (int j = 0; j < AA.GetLength(1); j++)
            {
                AA2[i] = AA2[i] + AA[i, j] + " ";
            }
        }
        File.WriteAllLines(path, AA2, Encoding.Default);
    }
    public static void ArrLine(string path, float[] AA)
    {
        string AS = "";
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        for (int i = 0; i < AA.Length; i++)
        {
            AS = AS + AA[i] + " ";
        }
        sw.WriteLine(AS);
        sw.Close();
    }
    public static void ArrNew(string path, float[] AA)
    {
        string AS = "";
        for (int i = 0; i < AA.Length; i++)
        {
            AS = AS + AA[i] + " ";
        }
        File.WriteAllText(path, AS);
    }
    public static void StringNew(string path, int read)
    {
        string str = Convert.ToString(read);
        File.WriteAllText(path, str);
    }
    public static void StringLine(string path, int line)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        sw.WriteLine(line);
        sw.Close();
    }
    public static void AALine(string path, int[][] AA)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.Length; i++)
        {
            for (int j = 0; j < AA[i].Length; j++)
            {
                AA2[i] = AA2[i] + AA[i][j] + " ";
            }
            sw.WriteLine(AA2[i]);
        }
        sw.Close();
    }
    public static void AANew(string path, int[][] AA)
    {
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.Length; i++)
        {
            for (int j = 0; j < AA[i].Length; j++)
            {
                AA2[i] = AA2[i] + AA[i][j] + " ";
            }
        }
        File.WriteAllLines(path, AA2, Encoding.Default);
    }
    public static void MatLine(string path, int[,] AA)
    {
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.GetLength(1); i++)
        {
            for (int j = 0; j < AA.GetLength(1); j++)
            {
                AA2[i] = AA2[i] + AA[i, j] + " ";
            }
            sw.WriteLine(AA2[i]);
        }
        sw.Close();
    }
    public static void MatNew(string path, int[,] AA)
    {
        string[] AA2 = new string[AA.Length];
        for (int i = 0; i < AA.GetLength(1); i++)
        {
            for (int j = 0; j < AA.GetLength(1); j++)
            {
                AA2[i] = AA2[i] + AA[i, j] + " ";
            }
        }
        File.WriteAllLines(path, AA2, Encoding.Default);
    }
    public static void ArrLine(string path, int[] AA)
    {
        string AS = "";
        StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
        for (int i = 0; i < AA.Length; i++)
        {
            AS = AS + AA[i] + " ";
        }
        sw.WriteLine(AS);
        sw.Close();
    }
    public static void ArrNew(string path, int[] AA)
    {
        string AS = "";
        for (int i = 0; i < AA.Length; i++)
        {
            AS = AS + AA[i] + " ";
        }
        File.WriteAllText(path, AS);
    }
}

