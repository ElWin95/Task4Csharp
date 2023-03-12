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
            #region Task10
            //    int num1, num2, num3, num4, num5, num6, max;
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
            //L3:
            //    Console.Write("3. ededi daxil edin: ");
            //    string strNum3 = Console.ReadLine();
            //    if (!int.TryParse(strNum3, out num3))
            //    {
            //        goto L3;
            //    }
            //L4:
            //    Console.Write("4. ededi daxil edin: ");
            //    string strNum4 = Console.ReadLine();
            //    if (!int.TryParse(strNum4, out num4))
            //    {
            //        goto L4;
            //    }
            //L5:
            //    Console.Write("5. ededi daxil edin: ");
            //    string strNum5 = Console.ReadLine();
            //    if (!int.TryParse(strNum5, out num5))
            //    {
            //        goto L5;
            //    }
            //L6:
            //    Console.Write("6. ededi daxil edin: ");
            //    string strNum6 = Console.ReadLine();
            //    if (!int.TryParse(strNum6, out num6))
            //    {
            //        goto L6;
            //    }
            //    max = num1;
            //   if (num2 > max)
            //    {
            //        max = num2;
            //    }
            //    if (num3 > max)
            //    {
            //        max = num3;
            //    }
            //    if (num4 > max)
            //    {
            //        max = num4;
            //    }
            //    if (num5 > max)
            //    {
            //        max = num5;
            //    }
            //    if (num6 > max)
            //    {
            //        max = num6;
            //    }
            //    Console.WriteLine($"Verilen 6 ededden en boyuk olani {max}-dir");
            #endregion
            #region Task11
            //    int num, firstNum, lastNum, newNum1, newNum2, newNum3, newNum4;
            //    int remainder1 = 0;
            //    int remainder2 = 0;
            //L1:
            //    Console.Write("6 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 6)
            //    {
            //        goto L1;
            //    }
            //    firstNum = num / 1000;
            //    lastNum = num % 1000;
            //    while (firstNum > 0)
            //    {
            //        remainder1 += (firstNum % 10);
            //        firstNum = firstNum / 10;
            //    }
            //    while (lastNum > 0)
            //    {
            //        remainder2 += (lastNum % 10);
            //        lastNum = lastNum / 10;
            //    }
            //    newNum1 = num / 10000;
            //    newNum2 = num % 100;
            //    newNum4 = (num / 100) % 100;
            //    if (remainder1 == remainder2) 
            //    {
            //        newNum3 = (newNum2 * 100 + newNum1) + newNum4;
            //        Console.WriteLine($"Netice: {newNum3}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Verilmis 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraber deyil");
            //    }
            #endregion
            #region Task12
            //    int num, num1, firstNum, lastNum, newNum1, newNum2;
            //    int remainder = 0;
            //L1:
            //    Console.Write("6 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 6)
            //    {
            //        goto L1;
            //    }
            //    int power1 = (int)Math.Pow(10, numDigit);
            //    int power2 = (int)Math.Pow(10, numDigit - 2);
            //    firstNum = (power1 * 8 + num) * 10 + 8;
            //    lastNum = (firstNum % power2) * power2 + (firstNum / power2);
            //    newNum1 = 0;
            //    while (lastNum > 0)
            //    {
            //        remainder = lastNum % 10;
            //        lastNum /= 10;
            //        newNum1 = newNum1 * 10 + remainder;
            //    }
            //    num1 = newNum1;
            //    newNum2 = 0;
            //    bool next = true;
            //    while (num1 > 0)
            //    {
            //        remainder = num1 % 10;
            //        num1 /= 10;
            //        if (next == true)
            //        {
            //            next = !next;
            //            continue;
            //        }
            //        next = !next;
            //        newNum2 = newNum2 * 100 + remainder;
            //    }
            //    Console.WriteLine(newNum2);
            #endregion
            #region Task13
            //    int num, newNum1;
            //    int newNum2 = 0;
            //    int count = 0;
            //    int remainder = 0;
            //L1:
            //    Console.Write("7 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 7)
            //    {
            //        goto L1;
            //    }
            //    newNum1 = num;
            //    while (newNum1 > 0)
            //    {
            //        remainder = newNum1 % 10;
            //        newNum1 /= 10;
            //        newNum2 = newNum2 * 10 + remainder;
            //    }
            //    if (newNum2 == num)
            //    {
            //        while (newNum2 > 0)
            //        {
            //            remainder = newNum2 % 10;
            //            newNum2 /= 10;
            //            if (remainder == 0)
            //            {
            //                count++;
            //            }
            //        }
            //        Console.WriteLine($"Verilmis 7 reqemli ededin daxilinde {count} dene 0 var.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Verilmis 7 reqemli eded polindrom deyil");
            //    }
            #endregion
            #region Task14
            //    int num, numDigit, power, newNum;
            //    string strNum;
            //L1:
            //    Console.Write("Minimum 1, maksimum 8 reqemli ededi daxil edin: ");
            //    strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit > 8)
            //    {
            //        goto L1;
            //    }
            //    power = (int)Math.Pow(10, numDigit);
            //    newNum = power + num;
            //    Console.WriteLine(newNum);
            #endregion
            #region Task15
            //    int num;
            //    string strNum;
            //L1:
            //    Console.Write("Minimum 1, maksimum 365 ededini daxil edin: ");
            //    strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    if (num < 1 || num > 365)
            //    {
            //        goto L1;
            //    }
            //    DateTime dt = new DateTime(2023, 1, 1);
            //    dt = dt.AddDays(num - 1);
            //    Console.WriteLine($"Daxil etdiyiniz edede uygun bu aydir: {dt.ToString("MMMM")}");
            //    if (dt.Month == 12 && dt.Day >= 22 || dt.Month == 1 && dt.Day <= 20)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Oglaqdir");
            //    }
            //    else if (dt.Month == 1 && dt.Day >= 21 || dt.Month == 2 && dt.Day <= 19)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Dolcadir");
            //    }
            //    else if (dt.Month == 2 && dt.Day >= 20 || dt.Month == 3 && dt.Day <= 20)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Baliqdir");
            //    }
            //    else if (dt.Month == 3 && dt.Day >= 21 || dt.Month == 4 && dt.Day <= 20)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Qocdur");
            //    }
            //    else if (dt.Month == 4 && dt.Day >= 21 || dt.Month == 5 && dt.Day <= 20)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Bugadir");
            //    }
            //    else if (dt.Month == 5 && dt.Day >= 21 || dt.Month == 6 && dt.Day <= 21)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Ikizlerdir");
            //    }
            //    else if (dt.Month == 6 && dt.Day >= 22 || dt.Month == 7 && dt.Day <= 22)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Xercengdir");
            //    }
            //    else if (dt.Month == 7 && dt.Day >= 23 || dt.Month == 8 && dt.Day <= 23)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Shirdir");
            //    }
            //    else if (dt.Month == 8 && dt.Day >= 24 || dt.Month == 9 && dt.Day <= 23)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Qizdir");
            //    }
            //    else if (dt.Month == 9 && dt.Day >= 24 || dt.Month == 10 && dt.Day <= 23)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Terezidir");
            //    }
            //    else if (dt.Month == 10 && dt.Day >= 24 || dt.Month == 11 && dt.Day <= 22)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Eqrebdir");
            //    }
            //    else if (dt.Month == 11 && dt.Day >= 23 || dt.Month == 12 && dt.Day <= 21)
            //    {
            //        Console.WriteLine("Hemin gune uygun burc Yaydir");
            //    }
            #endregion
            #region Task16
        //    int num, numDigit, remainder, size;
        //    string strNum;
        //L1:
        //    Console.Write("6 reqemli ededi daxil edin: ");
        //    strNum = Console.ReadLine();
        //    if (!int.TryParse(strNum, out num))
        //    {
        //        goto L1;
        //    }
        //    numDigit = (int)Math.Log10(num) + 1;
        //    if (numDigit > 8)
        //    {
        //        goto L1;
        //    }
        //    int[] nums = new int[0];
        //    while (num > 0)
        //    {
        //        remainder = num % 10;
        //        num /= 10;

        //        if (Array.IndexOf(nums, remainder) == -1)
        //        {
        //            size = nums.Length;
        //            Array.Resize(ref nums, size + 1);
        //            nums[size] = remainder;
        //        }
        //    }
        //    Console.WriteLine($"Verilmis 6 reqemli ededdin daxilinde {nums.Length} dene unikal reqem var ve bunlar asagidakilardir");
        //    foreach (var item in nums)
        //    {
        //        Console.Write($"{item}, ");
        //    }
            #endregion
        }
    }
}