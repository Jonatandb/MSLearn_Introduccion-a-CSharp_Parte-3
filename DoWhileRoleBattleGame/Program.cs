Random random = new();

Console.Clear();

int hero = 10;
int monster = 10;
bool heroAttack = true;

do {

  int attack = random.Next(1, 11);
  if (heroAttack) {
    monster -= attack;
  } else {
    hero -= attack;
  }

  Console.WriteLine($"{(heroAttack ? "Monster" : "Hero")} was damaged and lost {attack} health and now has {(heroAttack ? monster : hero)} health. ");

  heroAttack = !heroAttack;

} while (hero > 0 && monster > 0);

Console.WriteLine($"{(hero > 0 ? "Hero" : "Monster")} wins!");

Console.ReadLine();