using System;

public class Program {


 public static void Main(string[] args) {

    Console.WriteLine("Please input Name: ");
     string nameInput = Console.ReadLine();
    Console.WriteLine("Please input Number: ");
     double numberInput = double.Parse(Console.ReadLine());
    Console.WriteLine("Please input Owner Name: ");
     string ownernameInput = Console.ReadLine();
    Console.WriteLine("Please input Registered Value: ");
     double valueInput = double.Parse(Console.ReadLine());
     info myinfo = new info(nameInput,numberInput,ownernameInput,valueInput);
     info(myinfo);

         double money;
        while (true) {
           Console.WriteLine("Please input money: ");

            if (!double .TryParse(Console.ReadLine(), out money)) {
                Console.WriteLine("ERROR!! Please input Number!!!");
                continue;
                }
         break;
        }
        Money.money(money);

 }

 static void info(info info) {
   Console.WriteLine(" —--------- Shop Information —-----");
   Console.WriteLine("Name: {0} ", info.name);
   Console.WriteLine("Number: {0} ", info.number);
   Console.WriteLine("Owner Name: {0}", info.ownername);
   Console.WriteLine("Registered Value: {0}", info.value);
   Console.WriteLine("**************************");
 }

}