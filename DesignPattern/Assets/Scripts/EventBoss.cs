using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class EventBoss : Boss
{
    string dropItem1;
    public override void Attack()
    {
        Debug.Log(this.name + " : 공격!");
    }

    public override void DropItem(string name)
    {
        Debug.Log(dropItem1 + " : 드랍!");
    }

    // Start is called before the first frame update
    void Start()
    {
        type = BossType.Type1_Normal;
        hp = 200;
        exp = 100;
        dropItem1 = "Sword by Type1_Normal Boss";
        name = "Event Boss 1";
        Debug.Log(this.name + " : 출현");
    }

}
