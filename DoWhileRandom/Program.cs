Random random = new Random();

Console.Clear();

int current = 0;

do {
  current = random.Next(1,11);
  Console.WriteLine($"Current: {current}");
} while (current != 7);

Console.ReadLine();
