using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon 
{
    // Shoot 을 Interface 에서 선언
    //void Shoot();

    // Shoot 을 하는 매개변수를 받아와서 그 매개변수를 Shoot 하려고 하기 때문임.
    void Shoot(GameObject obj);

}
