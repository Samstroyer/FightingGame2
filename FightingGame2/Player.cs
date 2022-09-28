using System;

public class Player : Entity
{
    private int money;
    private List<WeaponBase> weapons;

    public Player()
    {
        weapons.Add(new MeeleWeapon());
        weapons.Add(new RangedWeapon());

    }


}
