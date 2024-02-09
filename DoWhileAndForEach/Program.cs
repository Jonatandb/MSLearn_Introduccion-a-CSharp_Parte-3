Console.Clear();

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string innerString in myStrings) {

  string myString = innerString;

  int periodLocation = 0;

  do {

    periodLocation = myString.IndexOf(".");

    if (periodLocation != -1) {

        Console.WriteLine(myString.Substring(0, periodLocation).TrimStart());
        myString = myString.Remove(0, periodLocation + 1);

    } else if (myString.Length > 0) {

        Console.WriteLine(myString.TrimStart());

    }

  } while(periodLocation > 0);

}


Console.ReadLine();