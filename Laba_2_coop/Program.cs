﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_coop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Який блок? (1 або 2)");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        Block1();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            }
        }
        static void Block1()
        {
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 3:
                    {
                        Var3b1();
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
            }
        }
        static void Var3b1()
        {
            int num = int.Parse(Console.ReadLine());
            Print(Block1v3(num, HandmadeArraySpaces(num)));
            Console.ReadKey();
        }
        static int[,] CreateArrayHand(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string[] law = Console.ReadLine().Trim().Split();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(law[j]);
                }
            }
            return arr;
        }

        static void Randomfill(int n, int[] myArray)
        {

            Console.WriteLine("Enter the min value of the array:\t");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max value of the array:\t");
            int maxValue = int.Parse(Console.ReadLine());
            Random ran = new Random();

            Console.WriteLine("Your array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = ran.Next(minValue, maxValue);
                Console.Write(myArray[i] + " ");
            }

        }
        static void HandmadeEnter(int[] myArray)
        {

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter the number on {i} index:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
        }
        static int[] HandmadeArraySpaces(int n)
        {
            string[] spArr = Console.ReadLine().Trim().Split();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(spArr[i]);
            }
            return arr;
        }
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static int[] Block1v3(int num, int[] arr)
        {
            int key = int.Parse(Console.ReadLine());
            int keyInd = Array.IndexOf(arr, key);
            if (arr == null || keyInd < -1 || keyInd >= arr.Length)
            {
                Console.WriteLine("Видалити неможливо, " +
                "iндекс поза допустимими межами");
            }
            else if (keyInd == -1)
                Console.WriteLine("No this num");
            else
                Erase(ref arr, keyInd);
            return arr;
        }

        static int[] Erase(ref int[] arr, int keyInd)
        {
            for (int i = keyInd + 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }
        static void JaggArratInput(int n, int m, ref int[][] arr)
        {
            for (int i = 0; i < n; i++)
            {
                string[] arrElem = Console.ReadLine().Trim().Split();
                //arr[i] = Array.ConvertAll(
                // Console.ReadLine().Split("\"".ToCharArray(),StringSplitOptions. RemoveEmptyEntries), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    arr[i][j] = int.Parse(arrElem[j]);
                }
            }
        }
        static void PrintJaggArr(int n, int m, int[][] arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Block2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[][] jagArr = new int[n][];

        }
        static int[][] Var3Block2(int[][] arr)
        {
            int[][] bArr = (int[][])arr.Clone();
            return bArr;
        }
    }
}    

