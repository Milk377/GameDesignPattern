using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strategy_WeaponManager : MonoBehaviour
{
    MyWeapon myweapon;

    private void Start()
    {
        myweapon = new MyWeapon();

        //Set default bullet
        myweapon.setWeapon(new Arrow());
    }

    public void ChangeMissile()
    {
        myweapon.setWeapon(new Missile());
    }

    public void ChangeLaser()
    {
        myweapon.setWeapon(new Laser());
    }

    public void ChangeArrow()
    {
        myweapon.setWeapon(new Arrow());
    }

    public void Fire()
    {
        myweapon.Shoot();
    }




}
