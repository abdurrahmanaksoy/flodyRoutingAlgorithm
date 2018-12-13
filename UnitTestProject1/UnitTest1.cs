using System;
using System.Linq;
using FlodyRoutingAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[][] matrix1 = new double[6][]{
                new double[6],
                new double[6],
                new double[6],
                new double[6],
                new double[6],
                new double[6]
            };

            matrix1[0][0] = 0;
            matrix1[0][1] = 5;
            matrix1[0][2] = 6;
            matrix1[0][3] = 7;
            matrix1[0][4] = 11;
            matrix1[0][5] = 7;

            matrix1[1][0] = 5;
            matrix1[1][1] = 0;
            matrix1[1][2] = 1;
            matrix1[1][3] = 2;
            matrix1[1][4] = 6;
            matrix1[1][5] = 2;

            matrix1[2][0] = 6;
            matrix1[2][1] = 1;
            matrix1[2][2] = 0;
            matrix1[2][3] = 1;
            matrix1[2][4] = 5;
            matrix1[2][5] = 3;

            matrix1[3][0] = 7;
            matrix1[3][1] = 2;
            matrix1[3][2] = 1;
            matrix1[3][3] = 0;
            matrix1[3][4] = 4;
            matrix1[3][5] = 4;

            matrix1[4][0] = 11;
            matrix1[4][1] = 6;
            matrix1[4][2] = 5;
            matrix1[4][3] = 4;
            matrix1[4][4] = 0;
            matrix1[4][5] = 4;

            matrix1[5][0] = 7;
            matrix1[5][1] = 2;
            matrix1[5][2] = 3;
            matrix1[5][3] = 4;
            matrix1[5][4] = 4;
            matrix1[5][5] = 0;

            double[][] proximityMatrix = Program.PrepareFirstState();
            Program.Solve(ref proximityMatrix);
            CollectionAssert.AreEqual(proximityMatrix, matrix1);
        }
        public static void Solve(ref double[][] matrix)
        {
            int size = matrix.Count();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        matrix[j][k] = System.Math.Min(matrix[j][k], matrix[j][i] + matrix[i][k]);
                    }
                }
            }
        }

    }
}
