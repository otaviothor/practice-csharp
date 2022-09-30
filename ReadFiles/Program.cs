const string filePath = @"/home/otaviosilva/Development/portfolio/practice-c#/ReadFiles/text-file.txt";

// esse metodo vai retornar todo o conteudo do arquivo numa so string
// var data = File.ReadAllText(filePath);
// Console.WriteLine(data);

// esse metodo vai retornar todo o conteudo do arquivo separados por linhas num array
// var data = File.ReadAllLines(filePath);
// var count = 0;
// foreach (var line in data)
// {
//   count++;
//   Console.WriteLine($"{count}. {line}");
// }

// esse metodo vai retornar todo o conteudo do arquivo em partes
using var file = new StreamReader(filePath);
string? line;

while ((line = file.ReadLine()) != null)
  Console.WriteLine(line);

file.Close();