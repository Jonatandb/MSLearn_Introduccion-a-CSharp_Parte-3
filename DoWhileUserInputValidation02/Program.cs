Console.Clear();

bool isValidEntry = false;
string? entry = "";

Console.WriteLine("Enter your role name (Administrator, Manager, or User):");

do {

  entry = Console.ReadLine();

  if(!string.IsNullOrEmpty(entry)) {
    entry = entry.Trim();
    entry = entry.ToLower();
  }

  if((entry == "administrator") || (entry == "manager") || (entry == "user")) {
    isValidEntry = true;
  } else {
    Console.WriteLine($"The role name that you entered, \"{entry}\" is not valid. Enter your role name (Administrator, Manager, or User):");
  }

} while (isValidEntry == false);

string capitalizedEntry = char.ToUpper(entry[0]) + entry.Substring(1);

Console.WriteLine($"Your input value ({capitalizedEntry}) has been acepted.");


Console.ReadLine();
