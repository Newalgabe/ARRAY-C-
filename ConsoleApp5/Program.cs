// task 1
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[] A = new double[5];

//        for (int i = 0; i < A.Length; i++)
//        {
//            Console.Write($"Enter the value for element {i + 1}: ");
//            A[i] = Convert.ToDouble(Console.ReadLine());
//        }

//        Random random = new Random();
//        double[,] B = new double[3, 4];

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                B[i, j] = random.NextDouble();
//            }
//        }

//        Console.WriteLine("Array A:");
//        for (int i = 0; i < A.Length; i++)
//        {
//            Console.Write(A[i] + " ");
//        }
//        Console.WriteLine();

//        Console.WriteLine("Array B:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write(B[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }

//        double maxA = A[0];
//        double maxB = B[0, 0];

//        foreach (double value in A)
//        {
//            if (value > maxA)
//            {
//                maxA = value;
//            }
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                if (B[i, j] > maxB)
//                {
//                    maxB = B[i, j];
//                }
//            }
//        }

//        Console.WriteLine($"Maximum element in A: {maxA}");
//        Console.WriteLine($"Maximum element in B: {maxB}");

//        double minA = A[0];
//        double minB = B[0, 0];

//        foreach (double value in A)
//        {
//            if (value < minA)
//            {
//                minA = value;
//            }
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                if (B[i, j] < minB)
//                {
//                    minB = B[i, j];
//                }
//            }
//        }

//        Console.WriteLine($"Minimum element in A: {minA}");
//        Console.WriteLine($"Minimum element in B: {minB}");

//        double sumA = 0;
//        double sumB = 0;

//        foreach (double value in A)
//        {
//            sumA += value;
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                sumB += B[i, j];
//            }
//        }

//        Console.WriteLine($"Sum of all elements in A: {sumA}");
//        Console.WriteLine($"Sum of all elements in B: {sumB}");

//        double productA = 1;
//        double productB = 1;

//        foreach (double value in A)
//        {
//            productA *= value;
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                productB *= B[i, j];
//            }
//        }

//        Console.WriteLine($"Product of all elements in A: {productA}");
//        Console.WriteLine($"Product of all elements in B: {productB}");

//        double evenSumA = 0;

//        foreach (double value in A)
//        {
//            if (value % 2 == 0)
//            {
//                evenSumA += value;
//            }
//        }

//        Console.WriteLine($"Sum of even elements in A: {evenSumA}");

//        double oddColumnSumB = 0;

//        for (int j = 0; j < 4; j++)
//        {
//            if (j % 2 != 0)
//            {
//                for (int i = 0; i < 3; i++)
//                {
//                    oddColumnSumB += B[i, j];
//                }
//            }
//        }

//        Console.WriteLine($"Sum of elements in odd columns of B: {oddColumnSumB}");
//    }
//}



// task 2
//const int rows = 5;
//const int columns = 5;
//int[,] array = new int[rows, columns];

//    Random random = new Random();
//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < columns; j++)
//        {
//            array[i, j] = random.Next(-100, 101);
//        }
//    }

//    int minElement = array[0, 0];
//    int maxElement = array[0, 0];
//    int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < columns; j++)
//        {
//            if (array[i, j] < minElement)
//            {
//                minElement = array[i, j];
//                minRow = i;
//                minCol = j;
//            }
//            if (array[i, j] > maxElement)
//            {
//                maxElement = array[i, j];
//                maxRow = i;
//                maxCol = j;
//            }
//        }
//    }

//int sum = 0;

//int startRow, endRow;
//if (minRow < maxRow)
//{
//    startRow = minRow;
//    endRow = maxRow;
//}
//else
//{
//    startRow = maxRow;
//    endRow = minRow;
//}

//int startCol, endCol;
//if (minCol < maxCol)
//{
//    startCol = minCol;
//    endCol = maxCol;
//}
//else
//{
//    startCol = maxCol;
//    endCol = minCol;
//}

//for (int i = startRow; i <= endRow; i++)
//    {
//        for (int j = startCol; j <= endCol; j++)
//        {
//            sum += array[i, j];
//        }
//    }

//    Console.WriteLine("Array:");
//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < columns; j++)
//        {
//            Console.Write(array[i, j] + "\t");
//        }
//        Console.WriteLine();
//    }

//    Console.WriteLine($"Minimum element: {minElement} (located at [{minRow},{minCol}])");
//    Console.WriteLine($"Maximum element: {maxElement} (located at [{maxRow},{maxCol}])");
//    Console.WriteLine($"Sum of elements between the minimum and maximum elements: {sum}");



// task 3
//class CaesarCipher
//{
//    static string Encrypt(string text, int shift)
//    {
//        char[] encryptedText = new char[text.Length];

//        for (int i = 0; i < text.Length; i++)
//        {
//            char originalChar = text[i];

//            if (char.IsUpper(originalChar))
//            {
//                char encryptedChar = (char)(((originalChar - 'A' + shift) % 26) + 'A');
//                encryptedText[i] = encryptedChar;
//            }

//            else if (char.IsLower(originalChar))
//            {
//                char encryptedChar = (char)(((originalChar - 'a' + shift) % 26) + 'a');
//                encryptedText[i] = encryptedChar;
//            }

//            else
//            {
//                encryptedText[i] = originalChar;
//            }
//        }

//        return new string(encryptedText);
//    }

//    static string Decrypt(string encryptedText, int shift)
//    {
//        shift = -shift;
//        return Encrypt(encryptedText, shift);
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter a string to encrypt: ");
//        string inputText = Console.ReadLine();

//        Console.Write("Enter a shift value (an integer): ");
//        if (!int.TryParse(Console.ReadLine(), out int shift))
//        {
//            Console.WriteLine("Error: Please enter an integer for the shift value.");
//            return;
//        }

//        string encryptedText = Encrypt(inputText, shift);
//        Console.WriteLine($"Encrypted string: {encryptedText}");

//        string decryptedText = Decrypt(encryptedText, shift);
//        Console.WriteLine($"Decrypted string: {decryptedText}");
//    }
//}


// task 4
//class MatrixOperations
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Matrix A:");
//        double[,] matrixA = ReadMatrix();
//        Console.WriteLine("Matrix B:");
//        double[,] matrixB = ReadMatrix();

//        Console.WriteLine("Select operation:");
//        Console.WriteLine("1. Multiply matrix by a number");
//        Console.WriteLine("2. Add matrices");
//        Console.WriteLine("3. Multiply matrices");
//        Console.Write("Enter your choice (1/2/3): ");

//        if (!int.TryParse(Console.ReadLine(), out int choice))
//        {
//            Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
//            return;
//        }

//        switch (choice)
//        {
//            case 1:
//                Console.Write("Enter a number to multiply matrix A by: ");
//                if (!double.TryParse(Console.ReadLine(), out double scalar))
//                {
//                    Console.WriteLine("Invalid input. Please enter a valid number.");
//                    return;
//                }
//                MultiplyMatrixByScalar(matrixA, scalar);
//                break;
//            case 2:
//                if (matrixA.GetLength(0) != matrixB.GetLength(0) || matrixA.GetLength(1) != matrixB.GetLength(1))
//                {
//                    Console.WriteLine("Matrix dimensions are not compatible for addition.");
//                    return;
//                }
//                AddMatrices(matrixA, matrixB);
//                break;
//            case 3:
//                if (matrixA.GetLength(1) != matrixB.GetLength(0))
//                {
//                    Console.WriteLine("Matrix dimensions are not compatible for multiplication.");
//                    return;
//                }
//                MultiplyMatrices(matrixA, matrixB);
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
//                break;
//        }
//    }

//    static double[,] ReadMatrix()
//    {
//        Console.Write("Enter the number of rows: ");
//        if (!int.TryParse(Console.ReadLine(), out int rows))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number of rows.");
//            Environment.Exit(1);
//        }

//        Console.Write("Enter the number of columns: ");
//        if (!int.TryParse(Console.ReadLine(), out int columns))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number of columns.");
//            Environment.Exit(1);
//        }

//        double[,] matrix = new double[rows, columns];

//        Console.WriteLine($"Enter {rows}x{columns} matrix elements:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                if (!double.TryParse(Console.ReadLine(), out matrix[i, j]))
//                {
//                    Console.WriteLine("Invalid input. Please enter valid numeric values.");
//                    Environment.Exit(1);
//                }
//            }
//        }

//        return matrix;
//    }

//    static void MultiplyMatrixByScalar(double[,] matrix, double scalar)
//    {
//        int rows = matrix.GetLength(0);
//        int columns = matrix.GetLength(1);

//        Console.WriteLine("Resulting matrix:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                matrix[i, j] *= scalar;
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void AddMatrices(double[,] matrixA, double[,] matrixB)
//    {
//        int rows = matrixA.GetLength(0);
//        int columns = matrixA.GetLength(1);

//        double[,] result = new double[rows, columns];

//        Console.WriteLine("Resulting matrix:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                result[i, j] = matrixA[i, j] + matrixB[i, j];
//                Console.Write(result[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void MultiplyMatrices(double[,] matrixA, double[,] matrixB)
//    {
//        int rowsA = matrixA.GetLength(0);
//        int columnsA = matrixA.GetLength(1);
//        int columnsB = matrixB.GetLength(1);

//        double[,] result = new double[rowsA, columnsB];

//        Console.WriteLine("Resulting matrix:");
//        for (int i = 0; i < rowsA; i++)
//        {
//            for (int j = 0; j < columnsB; j++)
//            {
//                double sum = 0;
//                for (int k = 0; k < columnsA; k++)
//                {
//                    sum += matrixA[i, k] * matrixB[k, j];
//                }
//                result[i, j] = sum;
//                Console.Write(result[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}


// task 5 
//class ArithmeticCalculator
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter an arithmetic expression (+ and -): ");
//        string input = Console.ReadLine();

//        // .Split используется для разбиения строки введенной пользователем на токены (части арифметического выражения разделенные пробелами)
//        string[] tokens = input.Split(' ');

//        if (tokens.Length % 2 == 0)
//        {
//            Console.WriteLine("Error: Incorrect number of operands and operators.");
//            return;
//        }

//        double result = double.Parse(tokens[0]);

//        for (int i = 1; i < tokens.Length; i += 2)
//        {
//            string op = tokens[i]; // Operator
//            double operand = double.Parse(tokens[i + 1]); 

//            if (op == "+")
//            {
//                result += operand;
//            }
//            else if (op == "-")
//            {
//                result -= operand;
//            }
//            else
//            {
//                Console.WriteLine($"Error: Unknown operator {op}.");
//                return;
//            }
//        }

//        Console.WriteLine($"Result: {result}");
//    }
//}



// task 6
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the text:");
//        string inputText = Console.ReadLine();

//        string resultText = UppercaseFirstLetterInSentencesManually(inputText);

//        Console.WriteLine("Result:");
//        Console.WriteLine(resultText);
//    }

//    static string UppercaseFirstLetterInSentencesManually(string text)
//    {
//        char[] sentenceSeparators = { '.', '!', '?' };
//        char[] textChars = text.ToCharArray();

//        bool capitalizeNext = true;

//        for (int i = 0; i < textChars.Length; i++)
//        {
//            if (Array.Exists(sentenceSeparators, separator => separator == textChars[i]))
//            {
//                capitalizeNext = true;
//            }
//            else if (capitalizeNext && Char.IsLetter(textChars[i]))
//            {
//                textChars[i] = Char.ToUpper(textChars[i]);
//                capitalizeNext = false;
//            }
//        }

//        return new string(textChars);
//    }
//}



// task 7
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the text:");
//        string inputText = Console.ReadLine();

//        Console.WriteLine("Enter the invalid words (separated by commas):");
//        string invalidWordsInput = Console.ReadLine();
//        string[] invalidWords = invalidWordsInput.Split(',');

//        int replacementsCount = 0;

//        foreach (string word in invalidWords)
//        {
//            string trimmedWord = word.Trim();
//            string[] words = inputText.Split(new[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

//            for (int i = 0; i < words.Length; i++)
//            {
//                if (string.Equals(words[i], trimmedWord, StringComparison.OrdinalIgnoreCase))
//                {
//                    words[i] = new string('*', trimmedWord.Length);
//                    replacementsCount++;
//                }
//            }

//            inputText = string.Join(" ", words);
//        }

//        Console.WriteLine("Result:");
//        Console.WriteLine(inputText);
//        Console.WriteLine($"Statistics: {replacementsCount} replacement(s) of invalid word(s).");
//    }
//}