public class Weapon
{
    protected string name;
    protected int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"Attacking with {name} - Damage: {damage}");
    }

    public string GetName()
    {
        return name;
    }
}

public class Sword : Weapon
{
    public Sword() : base("Sword", 20)
    {
    }

    // Optionally, you can override the Attack method for a specific behavior
    public override void Attack()
    {
        base.Attack();
        Console.WriteLine("Swinging the sword!");
    }
}

public class Axe : Weapon
{
    public Axe() : base("Axe", 25)
    {
    }

    // Optionally, you can override the Attack method for a specific behavior
    public override void Attack()
    {
        base.Attack();
        Console.WriteLine("Swinging the axe!");
    }
}

public class Knight
{
    private string name;
    private Weapon weapon;

    public Knight(string name, Weapon weapon)
    {
        this.name = name;
        this.weapon = weapon;
    }

    public void Attack()
    {
        Console.WriteLine($"{name} is attacking!");
        weapon.Attack();
    }

    public void EquipWeapon(Weapon newWeapon)
    {
        weapon = newWeapon;
        Console.WriteLine($"{name} has equipped {weapon.GetName()}!");
    }
}

class Program
{
    static void Main()
    {
        // Creating different types of weapons
        Sword sword = new Sword();
        Axe axe = new Axe();

        // Creating a knight with a sword
        Knight knight = new Knight("Sir Lancelot", sword);

        // Knight attacks with the sword
        knight.Attack();

        // Knight equips an axe
        knight.EquipWeapon(axe);

        // Knight attacks with the axe
        knight.Attack();
    }
}
