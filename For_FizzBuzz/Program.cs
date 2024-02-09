Console.Clear();

for(int n = 1; n <= 100; n++) {
  if ((n % 3 == 0) && (n % 5 == 0)) {
    Console.WriteLine($"{n} - FizzBuzz");
  } else if (n % 3 == 0) {
    Console.WriteLine($"{n} - Fizz");
  } else if (n % 5 == 0) {
    Console.WriteLine($"{n} - Buzz");
  } else {
    Console.WriteLine($"{n}");
  }
}

Console.ReadLine();