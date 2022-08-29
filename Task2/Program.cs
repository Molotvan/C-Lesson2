String n = new Random().Next(1, 10000).ToString();
Console.WriteLine(n);
Char[] numbers = n.ToCharArray();
if(numbers.Length >= 3){
Console.WriteLine(numbers[2]);
}else{
    Console.WriteLine("Третьей цифры нет");
}