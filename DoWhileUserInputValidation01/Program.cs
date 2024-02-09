Console.Clear();

bool validEntry = false;
string? entry = null;
int value = 0;

Console.WriteLine("Enter an integer value betweenn 5 and 10:");

do {

  entry = Console.ReadLine();
  validEntry = int.TryParse(entry, out value);
  if(validEntry) {
    if(value < 5 || value > 10) {
      Console.WriteLine($"You entered {value}. Please enter a number between 5 and 10.");
      validEntry = false;
    }
  } else {
    Console.WriteLine("Sorry, you entered an invalid number, please try again");
  }

} while (validEntry == false);

Console.WriteLine($"Your input value ({value}) has been acepted.");


Console.ReadLine();
