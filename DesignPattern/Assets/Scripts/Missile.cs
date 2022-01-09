using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour, IWeapon
{
    public void Shoot(GameObject obj)
    {
        Debug.Log("Fire Missile");
        Vector3 spawnPoint = new Vector3(transform.position.x, transform.position.y +1.5f, 0);
        GameObject bullet = Instantiate(obj) as GameObject;
        bullet.transform.position = spawnPoint;
    }
}
