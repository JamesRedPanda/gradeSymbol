string welcome = @"
 /$$   /$$         /$$                      /$$$$$$                          /$$                 /$$
|__/  /$$/        | $$                     /$$__  $$                        | $$                | $$
     /$$/        /$$$$$$    /$$$$$$       | $$  \__/ /$$   /$$ /$$$$$$/$$$$ | $$$$$$$   /$$$$$$ | $$
    /$$/        |_  $$_/   /$$__  $$      |  $$$$$$ | $$  | $$| $$_  $$_  $$| $$__  $$ /$$__  $$| $$
   /$$/           | $$    | $$  \ $$       \____  $$| $$  | $$| $$ \ $$ \ $$| $$  \ $$| $$  \ $$| $$
  /$$/            | $$ /$$| $$  | $$       /$$  \ $$| $$  | $$| $$ | $$ | $$| $$  | $$| $$  | $$| $$
 /$$/  /$$        |  $$$$/|  $$$$$$/      |  $$$$$$/|  $$$$$$$| $$ | $$ | $$| $$$$$$$/|  $$$$$$/| $$
|__/  |__/         \___/   \______/        \______/  \____  $$|__/ |__/ |__/|_______/  \______/ |__/
                                                     /$$  | $$                                      
                                                    |  $$$$$$/                                      
                                                     \______/                                       
  /$$$$$$                                                      /$$                                  
 /$$__  $$                                                    | $$                                  
| $$  \__/  /$$$$$$  /$$$$$$$  /$$    /$$ /$$$$$$   /$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$           
| $$       /$$__  $$| $$__  $$|  $$  /$$//$$__  $$ /$$__  $$|_  $$_/   /$$__  $$ /$$__  $$          
| $$      | $$  \ $$| $$  \ $$ \  $$/$$/| $$$$$$$$| $$  \__/  | $$    | $$$$$$$$| $$  \__/          
| $$    $$| $$  | $$| $$  | $$  \  $$$/ | $$_____/| $$        | $$ /$$| $$_____/| $$                
|  $$$$$$/|  $$$$$$/| $$  | $$   \  $/  |  $$$$$$$| $$        |  $$$$/|  $$$$$$$| $$                
 \______/  \______/ |__/  |__/    \_/    \_______/|__/         \___/   \_______/|__/                
                                                                                                    
                                                                                                    
                                                                                                    
";

string a = @"  /$$$$$$ 
 /$$__  $$
| $$  \ $$
| $$$$$$$$
| $$__  $$
| $$  | $$
| $$  | $$
|__/  |__/
          ";
string b = @" /$$$$$$$ 
| $$__  $$
| $$  \ $$
| $$$$$$$ 
| $$__  $$
| $$  \ $$
| $$$$$$$/
|_______/ 
         ";
string c = @"  /$$$$$$ 
 /$$__  $$
| $$  \__/
| $$      
| $$      
| $$    $$
|  $$$$$$/
 \______/ ";
string d = @" /$$$$$$$ 
| $$__  $$
| $$  \ $$
| $$  | $$
| $$  | $$
| $$  | $$
| $$$$$$$/
|_______/ ";
string e = @" /$$$$$$$$
| $$_____/
| $$      
| $$$$$   
| $$__/   
| $$      
| $$$$$$$$
|________/";
string f = @" /$$$$$$$$
| $$_____/
| $$      
| $$$$$   
| $$__/   
| $$      
| $$      
|__/     ";
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(welcome);

Console.WriteLine("Enter your percentage:");
string txtScore = Console.ReadLine();
Console.Clear();
try
{
    int numScore = int.Parse(txtScore);

    switch (numScore)
    {
        case >= 90 and <= 100:
            Console.WriteLine(a);
            break;
        case >= 80 and < 90:
            Console.WriteLine(b);
            break;
        case >= 70 and < 80:
            Console.WriteLine(c);
            break;
        case >= 60 and < 70:
            Console.WriteLine(d);
            break;
        case >= 50 and < 60:
            Console.WriteLine(e);
            break;
        case > 0 and < 50:
            Console.WriteLine(f);
            break;
        default:
            Console.WriteLine("Invalid input, you broke the program");
            break;
    }
}
catch
{
    Console.WriteLine("Invalid input, you broke the program");
}
Console.WriteLine("Press any key to exit the program");
Console.ReadKey();




