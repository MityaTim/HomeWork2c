string? readStr = Console.ReadLine();
if (!int.TryParse(readStr, out int _)) throw new System.Exception(readStr + "is not number");
Console.WriteLine(readStr[1]);