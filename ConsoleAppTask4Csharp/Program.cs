namespace ConsoleAppTask4Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
        //    int num;
        //L1:
        //    Console.Write("Ededi daxil edin: ");
        //    string strNum = Console.ReadLine();
        //    if (!int.TryParse(strNum, out num))
        //    {
        //        goto L1;
        //    }
        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine("Verilmis eded cutdur");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Verilmis eded tekdir");
        //    }
            #endregion
            #region Task2
            //    int result, num1, num2;
            //L1:
            //    Console.Write("1. ededi daxil edin: ");
            //    string strNum1 = Console.ReadLine();
            //    if (!int.TryParse(strNum1, out num1))
            //    {
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("2. ededi daxil edin: ");
            //    string strNum2 = Console.ReadLine();
            //    if (!int.TryParse(strNum2, out num2))
            //    {
            //        goto L2;
            //    }
            //    result = num1 / num2;
            //    if (num1 % num2 == 0)
            //    {
            //        Console.WriteLine($"Netice: {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bolunmur.");
            //    }
            #endregion
            #region Task3
            //    int num;
            //L1:
            //    Console.Write("Ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    if (num % 10 == 7)
            //    {
            //        Console.WriteLine("Verilmis ededin sonuncu reqemi 7 ile qurtarirmi: Beli");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Verilmis ededin sonuncu reqemi 7 ile qurtarirmi: Xeyr");
            //    }
            #endregion
            #region Task4
            //    int num, remainder1, remainder2;
            //L1:
            //    Console.Write("2 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 2)
            //    {
            //        goto L1;
            //    }
            //    remainder1 = num % 10;
            //    remainder2 = num / 10;
            //    if (remainder1 == remainder2)
            //    {
            //        Console.WriteLine("Verilmis ededin reqemleri eynidirmi: Beli");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Verilmis ededin reqemleri eynidirmi: Xeyr");
            //    }
            #endregion
            #region Task5
            //    int num, remainder1, remainder2, sum1, sum2;
            //L1:
            //    Console.Write("2 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 2)
            //    {
            //        goto L1;
            //    }
            //    remainder1 = num % 10;
            //    remainder2 = num / 10;
            //    sum1 = remainder1 + remainder2;
            //    if (sum1 % 2 == 0)
            //    {
            //        sum2 = remainder1 * remainder2;
            //        Console.WriteLine($"Verilmis ededin reqemlerinin hasili: {sum2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Verilmis ededin reqemleri cemi cut deyil");
            //    }
            #endregion
            #region Task6
            //    int num, firstNum, lastNum, secondNum, sum;
            //L1:
            //    Console.Write("3 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 3)
            //    {
            //        goto L1;
            //    }
            //    firstNum = num / 100;
            //    lastNum = num % 10;
            //    secondNum = (num / 10) % 10; 
            //    sum = firstNum + lastNum;
            //    if (sum == secondNum)
            //    {
            //        Console.WriteLine("Beli");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Xeyr");
            //    }
            #endregion
            #region Task7
            //    int num, firstNum, lastNum, secondNum, sum;
            //L1:
            //    Console.Write("3 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 3)
            //    {
            //        goto L1;
            //    }
            //    firstNum = num / 100;
            //    lastNum = num % 10;
            //    secondNum = (num / 10) % 10;
            //    sum = firstNum + lastNum + secondNum;
            //    if (sum == firstNum * firstNum)
            //    {
            //        Console.WriteLine("Beli");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Xeyr");
            //    }
            #endregion
            #region Task8
            //    int num, lastNum;
            //    string result;
            //L1:
            //    Console.Write("Ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    lastNum = num % 10;
            //    switch (lastNum)
            //    {
            //        case 1:
            //            result = "I gun";
            //            break;
            //        case 2:
            //            result = "II gun";
            //            break;
            //        case 3:
            //            result = "III gun";
            //            break;
            //        case 4:
            //            result = "IV gun";
            //            break;
            //        case 5:
            //            result = "V gun";
            //            break;
            //        case 6:
            //            result = "VI gun";
            //            break;
            //        case 7:
            //            result = "VII gun";
            //            break;
            //        default:
            //            result = "Verilen ededin sonuncu reqemi heftenin gunlarini ifade etmir.";
            //            break;
            //    }
            //    Console.WriteLine(result);
            #endregion
            #region Task9
            //    int num;
            //    string result;
            //L1:
            //    Console.Write("12 aydan birini eded ile yaz: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    if (num < 1 || num > 12)
            //    {
            //        goto L1;
            //    }
            //    switch (num)
            //    {
            //        case 1:
            //            result = "Yanvar";
            //            break;
            //        case 2:
            //            result = "Fevral";
            //            break;
            //        case 3:
            //            result = "Mart";
            //            break;
            //        case 4:
            //            result = "Aprel";
            //            break;
            //        case 5:
            //            result = "May";
            //            break;
            //        case 6:
            //            result = "Iyun";
            //            break;
            //        case 7:
            //            result = "Iyul";
            //            break;
            //        case 8:
            //            result = "Avqust";
            //            break;
            //        case 9:
            //            result = "Sentyabr";
            //            break;
            //        case 10:
            //            result = "Oktyabr";
            //            break;
            //        case 11:
            //            result = "Noyabr";
            //            break;
            //        case 12:
            //            result = "Dekabr";
            //            break;
            //        default:
            //            result = "Verilen eded ayi ifade etmir.";
            //            break;
            //    }
            //    Console.WriteLine(result);
            #endregion
        }
    }
}