string? str = Console.ReadLine();
if (!int.TryParse(str, out int _)) throw new Exception(str + " is not number");
if (str.Length > 2) Console.WriteLine(str[2]);
else Console.WriteLine("третьей цифры нет");