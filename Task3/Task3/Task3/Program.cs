// TODO: 3. Класс Матрица
// Создать класс "Матрица". Класс должен иметь следующие переменные:
// двумерный массив вещественных чисел;
// количество строк и столбцов в матрице.
// Класс должен иметь следующие методы:
// сложение с другой матрицей;
// умножение на число;
// вывод на печать;
// умножение матриц - по желанию.

using Task3;

double[,] matr = { { 1.0, 2.4, 3.1 }, { 4.2, 5.5, 6.6 } };

var matrix = new Matrix(matr);

Console.WriteLine(matrix.ToString());

Console.WriteLine(matrix.ScalarMultiplication(3.0).ToString());

double[,] matrForMult = { { 2.0, 4.1 }, { 3.0, 0.0 }, { 3.2, 1.0 } };

Console.WriteLine(matrix.MatrixMultiplication(matrForMult).ToString());

Console.WriteLine(matrix.MatrixSum(matr).ToString());