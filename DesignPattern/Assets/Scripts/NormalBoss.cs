using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public ���� �ϸ� �ȵ� 
class NormalBoss : Boss
{
    string dropItem2;
    public override void Attack()
    {
        Debug.Log(this.name + " : ����!");
    }

    public override void DropItem(string name)
    {
        Debug.Log(dropItem2 + " : ���!");
    }

    // Start is called before the first frame update
    void Start()
    {
        type = BossType.Type2_Normal;
        hp = 200;
        exp = 100;
        dropItem2 = "Sword by Type2_Normal Boss";
        name = "Event Boss 2";
        Debug.Log(this.name + " : ����");
    }

}
