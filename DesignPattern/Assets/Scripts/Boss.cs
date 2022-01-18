using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BossType
{
    Type1_Normal,
    Type1_Unique,
    Type2_Normal,
    Type2_Unique
}

// Boss 추상 클래스가 MonoBehaviour을 상속 받아도 되는가?
// 받으면 Boss가 상속받은 여러가지를 Boss를 구현하는 클래스에서 구현해야 하지 않을까?


abstract class Boss : MonoBehaviour
{
    protected BossType type;
    protected int hp;
    protected int exp;

    public abstract void Attack();
    public abstract void DropItem(string name);


  
}
