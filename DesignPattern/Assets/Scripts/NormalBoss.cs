using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public 으로 하면 안됨 
class NormalBoss : Boss
{
    string dropItem2;
    public override void Attack()
    {
        Debug.Log(this.name + " : 공격!");
    }

    public override void DropItem(string name)
    {
        Debug.Log(dropItem2 + " : 드랍!");
    }

    // Start is called before the first frame update
    void Start()
    {
        type = BossType.Type2_Normal;
        hp = 200;
        exp = 100;
        dropItem2 = "Sword by Type2_Normal Boss";
        name = "Event Boss 2";
        Debug.Log(this.name + " : 출현");
    }

}
