using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : IWeapon
{
    public void Shoot()
    {
        Debug.Log("Fire Laser");
    }

}
