/*Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. 
А программа сранивает два введенных числа и выводит на консоль результат сравнения 
    (два числа равны, первое число больше второго или первое число меньше второго).*/

/*Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber)
{
    Console.WriteLine("numbers are equal");
} else if (secondNumber < firstNumber)
{
    Console.WriteLine("first number bigger");
} else 
    Console.WriteLine("second number bigger");*/

/*
Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
    Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10".
    Иначе программа выводит сообщение "Неизвестное число".*/

/*Console.WriteLine("Enter the number");
int customerNumber = Convert.ToInt32(Console.ReadLine());
if (customerNumber > 5 && customerNumber < 10)
{
    Console.WriteLine("Number greater than 5 and less than 10");
}
else Console.WriteLine("Unknown number");*/

/*Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
    Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10".
    Иначе программа выводит сообщение "Неизвестное число".*/

/*Console.WriteLine("Enter number: ");
int customerNumber = Convert.ToInt32(Console.ReadLine());
if (customerNumber == 5 || customerNumber == 10)
{
    Console.WriteLine("The number is either 5 or 10");
}
else Console.WriteLine("Unknown number");*/

/*В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
Напишите консольную программу, в которую пользователь вводит сумму вклада. 
Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. 
Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.

Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())*/

/*Console.WriteLine("enter the deposit amount: ");
double customerDeposit = Convert.ToDouble(Console.ReadLine());

if (customerDeposit < 100 )
{
    double percent = customerDeposit * 0.05;
    double sum = customerDeposit + percent;
    Console.WriteLine($"Deposit {customerDeposit} + {percent} = {sum}");
} else if (customerDeposit > 100 || customerDeposit < 200)
{
    double percent = customerDeposit * 0.07;
    double sum = customerDeposit + percent;
    Console.WriteLine($"Deposit {customerDeposit} + percent {percent} = {sum}");
} else
{
    double percent = customerDeposit * 0.1;
    double sum = customerDeposit + percent;
    Console.WriteLine($"Deposit {customerDeposit} + {percent} = {sum}");
}*/

/*Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
    И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. 
    Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.*/



namespace ProjectOne
{
    class MainClass
    {
        static int num = 0;
        public static void Main(string[] args)
        {
            testFunc(num);
            testFunc(num);
            testFunc(num);

        }

        public static void testFunc(int num)
        {
            MainClass.num++;
            Console.Write(MainClass.num);
        }
    }
}


