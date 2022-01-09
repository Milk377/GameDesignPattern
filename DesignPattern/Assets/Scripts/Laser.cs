using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour, IWeapon
{
    public void Shoot(GameObject obj)
    {
        Debug.Log("Fire Laser");
        Vector3 spawnPoint = new Vector3(transform.position.x, transform.position.y + 1.5f, 0);
        GameObject bullet = Instantiate(obj) as GameObject;
        bullet.transform.position = spawnPoint;
    }

}
