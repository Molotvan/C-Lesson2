int day = new Random().Next(1, 7);
Console.WriteLine(day);
if(day == 6 || day ==7){
Console.WriteLine("Это выходной");
}else{
    Console.WriteLine("Это рабочий");
}
