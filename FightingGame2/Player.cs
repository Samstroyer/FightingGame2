using System;

public class Player : Entity
{
    public int money { get; set; }
    public List<WeaponBase> weaponBackpack { get; private set; } // Works: weapons.Add(new MeeleWeapon()); - - weapons.Add(new RangedWeapon());

    public Player()
    {

    }




}

public class Inventory
{
    public Inventory()
    {

    }
}