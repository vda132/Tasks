using System.Text;

namespace Task3;

public class Matrix
{
    private double[,] matrix;
    private int rows;
    private int columns;

    public Matrix(double[,] matrix)
    {
        this.matrix = matrix;
        this.rows = matrix.GetUpperBound(0) + 1;
        this.columns = matrix.Length / rows;
    }

    public Matrix MatrixSum(double[,] matrixB)
    {
        var columnsB = matrixB.Length / (matrixB.GetUpperBound(0) + 1);
        
        if (this.columns != columnsB)
            throw new Exception("Для матриц с разным размером сложение не возможно!");

        var matrixC = new double[rows, columnsB];

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columnsB; j++)
            {
                matrixC[i, j] = this.matrix[i, j] + matrixB[i, j];
            }
        }

        return new Matrix(matrixC);
    }

    public Matrix ScalarMultiplication(double number)
    {
        var resultMatrix = new double[rows, columns];

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = this.matrix[i, j] * number;
            }
        }
        
        return new Matrix(resultMatrix);
    }

    public Matrix MatrixMultiplication(double[,] matrixB)
    {
        if (this.columns != (matrixB.GetUpperBound(0) + 1))
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

        var columnsB = matrixB.Length / (matrixB.GetUpperBound(0) + 1);

        var matrixC = new double[this.rows, columnsB];

        for (var i = 0; i < this.rows; i++)
        {
            for (var j = 0; j < columnsB; j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < this.columns; k++)
                {
                    matrixC[i, j] += matrix[i, k] * matrixB[k, j];
                }
            }
        }

        return new Matrix(matrixC);
    }

    public override string ToString()
    {
        StringBuilder strMat = new StringBuilder();
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < columns; ++j)
            {
                strMat.Append(matrix[i, j].ToString() + " ");
            }
            strMat.Append("\n");
        }
        return strMat.ToString();
    }
}
