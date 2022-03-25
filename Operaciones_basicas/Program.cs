int[] num = new int[8];
num[0] = 12;
num[1] = 13;

num[2] = 11;
num[3] = 10;

num[4] = 14;
num[5] = 2;

num[6] = 2;
num[7] = 10;

int suma = num[0] + num[1];
int resta = num[2] - num[3];
int divide = num[4] / num[5];
int multiplica = num[6] * num[7];
Console.WriteLine("La suma de {0} + {1} es: {2}", num[0], num[1], suma);
Console.WriteLine("La resta de {0} - {1} es: {2}", num[2], num[3], resta);
Console.WriteLine("La multiplicacion de {0} * {1} es: {2}", num[6], num[7], multiplica);
Console.WriteLine("La divicion de {0} / {1} es: {2}", num[4], num[5], divide);
Console.ReadKey(true);