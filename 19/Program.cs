// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number.Length < 5 || number.Length > 5){
    Console.WriteLine("Введено неверное число");
}
else if (number[0] == number[4] && number[1] == number[3] ){
    Console.WriteLine("Да, введенное число - палиндром");    
}
else{
    Console.WriteLine("Нет, введенное число не является палиндромом");
}