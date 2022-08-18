//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sum = 0;
int n = Convert.ToInt32(Console.ReadLine());
while (n != 0) {
    sum += n % 10;
    n /= 10;
    Console.ReadLine(sum);
}
