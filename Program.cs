Console.Title = "Conversor Celsius/Kelvin";

double celsius, kelvin;

string[] frase = new string[24];
frase[0] = "C";
frase[1] = "o";
frase[2] = "n";
frase[3] = "v";
frase[4] = "e";
frase[5] = "r";
frase[6] = "s";
frase[7] = "o";
frase[8] = "r";
frase[9] = " ";
frase[10] = "C";
frase[11] = "e";
frase[12] = "l";
frase[13] = "s";
frase[14] = "i";
frase[15] = "u";
frase[16] = "s";
frase[17] = "/";
frase[18] = "K";
frase[19] = "e";
frase[20] = "l";
frase[21] = "v";
frase[22] = "i";
frase[23] = "n";

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.SetCursorPosition(5, 2);
Console.WriteLine("╔");
Console.SetCursorPosition(37, 2);
Console.WriteLine("╗");
Console.SetCursorPosition(5, 3);
Console.WriteLine("║                               ║");
Console.SetCursorPosition(5, 4);
Console.Write("╠");
Console.SetCursorPosition(37, 4);
Console.Write("╣");
Console.SetCursorPosition(5, 12);
Console.WriteLine("╚");
Console.SetCursorPosition(37, 12);
Console.WriteLine("╝");

for(int i = 0; i <= 30; i++){
    Console.SetCursorPosition(i+7,3);
    Console.SetCursorPosition(i+6,4);
    Console.Write("═");
    Console.SetCursorPosition(i+6,2);
    Console.Write("═");        
    Console.SetCursorPosition(i+6,12);
    Console.Write("═");
    Thread.Sleep(100);
}

for(int i = 0; i <= 6; i++){
    Console.SetCursorPosition(5, i+5);
    Console.WriteLine("║                               ║");
    Thread.Sleep(100);
}

for (int i = 0; i <= 23; i++){    
    Console.SetCursorPosition(i+9,3);
    Console.Write(frase[i]);
    Thread.Sleep(100);
}

Console.SetCursorPosition(6, 5);
Console.WriteLine("Digite temperatura em Celsius:");
Console.SetCursorPosition(6, 6);
celsius = Convert.ToDouble(Console.ReadLine().Replace(",","."));

kelvin = celsius + 273.15;

Console.SetCursorPosition(6, 7);
Console.WriteLine($"Convertida em Kelvin é: {kelvin:N2}°");
Console.SetCursorPosition(6, 8);


Console.SetCursorPosition(6, 9);
Console.WriteLine($"Obrigado!");

Console.SetCursorPosition(6, 10);
Console.WriteLine("Pressione uma tecla p/ sair...");

Console.SetCursorPosition(0, 13);
Console.ReadKey();

Console.SetCursorPosition(6, 11);
Console.WriteLine("FATEC 2022/2");
Console.ResetColor();