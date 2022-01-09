using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon
{
    private IWeapon weapon;

    public void setWeapon(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public void Shoot()
    {
        weapon.Shoot();
    }
}

