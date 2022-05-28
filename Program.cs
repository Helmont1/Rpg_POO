using static System.Console;
using Rpg_POO.src.Entities;

var Ainz = new Wizard("AinzOoalGown", 100, "Overlord", 999, 500);
var Gazeff = new Knight("GazeffStronoff", 50, "Knight", 450, 30);

WriteLine(Ainz.ShowStatus());
WriteLine(Gazeff.ShowStatus());

while (Ainz.Health > 0 && Gazeff.Health > 0)
{
    // bot turn
    if (Gazeff.Health > 0)
    {
        WriteLine("---------- Enemy turn ----------");
        WriteLine();
        WriteLine(Gazeff.Attack());
        WriteLine();
        WriteLine(Ainz.TakeDamage(Gazeff.Level));
        WriteLine();
        ReadKey();
        WriteLine();
    }
    else
    {
        break;
    }
    // player turn
    if (Ainz.Health > 0)
    {
        WriteLine("---------- Player turn ----------");
        WriteLine();
        WriteLine("What do you want to do?");
        WriteLine("1. Weak Spell (0 Mana)");
        WriteLine("2. Normal Spell (10 Mana)");
        WriteLine("3. Stronger Spell (20 Mana)");
        WriteLine("4. Strongest Spell (30 Mana)");
        int choice = int.Parse(ReadLine());
        switch (choice)
        {
            case 1:
                WriteLine(Ainz.Attack(0));
                WriteLine(Gazeff.TakeDamage(Ainz.Level));
                break;
            case 2:
                WriteLine(Ainz.Attack(1));
                WriteLine(Gazeff.TakeDamage(Ainz.Level + 20));
                break;
            case 3:
                WriteLine(Ainz.Attack(2));
                WriteLine(Gazeff.TakeDamage(Ainz.Level + 30));
                break;
            case 4:
                WriteLine(Ainz.Attack(3));
                WriteLine(Gazeff.TakeDamage(Ainz.Level + 899));
                break;
            default:
                WriteLine(Ainz.Attack(99));
                WriteLine(Gazeff.TakeDamage(0));
                break;
        }
        ReadKey();
    }
    else
    {
        break;
    }
    Clear();
    WriteLine(Ainz.ShowStatus());
    WriteLine(Gazeff.ShowStatus());

}

WriteLine("---------- You Win ----------");
WriteLine("Sasuga Ainz-Sama!");
Read();