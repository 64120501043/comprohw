    public class Money
    {
        public static double[] money(double money) 
        {
            
            double balance;
            double thousand;
            double fiveHundred;
            double hundred;
            double fifty;
            double twenty;
            double ten;
            double five;
            double two;
            double one;
            double _50;
            double _25;

            thousand = money / 1000;
            balance= money % 1000;
          

            fiveHundred = balance/ 500;
            balance= balance% 500;

            hundred = balance/ 100;
            balance= balance% 100;

            fifty = balance/ 50;
            balance= balance% 50;

            twenty = balance/ 20;
            balance= balance% 20;

            ten = balance/ 10;
            balance= balance% 10;

            five = balance/ 5;
            balance= balance% 5;

            two = balance/ 1;
            balance= balance% 1;

            one = balance/ 1;
            balance= balance% 1;

            _50 = balance/ .50;
            balance= balance% .50;

            _25 = balance/ .25;
            balance= balance% .25;



            Console.WriteLine(string.Format("1000 Baht :{0}", Math.Floor(thousand)));
            Console.WriteLine(string.Format("500 Baht :{0}", Math.Floor(fiveHundred)));
            Console.WriteLine(string.Format("100 Baht :{0}", Math.Floor(hundred)));
            Console.WriteLine(string.Format("50 Baht :{0}", Math.Floor(fifty)));
            Console.WriteLine(string.Format("20 Baht :{0}", Math.Floor(twenty)));
            Console.WriteLine(string.Format("10 Baht :{0}", Math.Floor(ten)));
            Console.WriteLine(string.Format("5 Baht :{0}", Math.Floor(five)));
            Console.WriteLine(string.Format("1 Baht :{0}", Math.Floor(two)));
            Console.WriteLine(string.Format("1 Baht :{0}", Math.Floor(one)));
            Console.WriteLine(string.Format("1 Baht :{0}", Math.Floor(_50)));
            Console.WriteLine(string.Format("1 Baht :{0}", Math.Floor(_25)));
            Console.ReadLine();

            double[] sum = { 
            Math.Floor(thousand), 
            Math.Floor(fiveHundred), 
            Math.Floor(hundred) , 
            Math.Floor(fifty), 
            Math.Floor(twenty), 
            Math.Floor(ten), 
            Math.Floor(five),
            Math.Floor(two), 
            Math.Floor(one) , 
            Math.Floor(_50),
            Math.Floor(_25)};
            return sum;
        }
    }