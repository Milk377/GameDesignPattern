using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unit�� ��ӹ޴� Marine �� public �� �ƴ϶� private����.

class Marine : Unit
{

    //private void Start()
    //{
    //    Debug.Log("Marine ����");
    //}

    //public override void Move()
    //{
    //    Debug.Log("Marine Move");
    //}

    //public override void Attack()
    //{
    //    Debug.Log("Marine Attack");
    //}

    public Marine()
    {
        type = UnitType.Marine;
        name = "Marine";
        hp = 100;
        exp = 50;

        Debug.Log(this.name + " : ����");
    }

    public override void Attack()
    {
        Debug.Log(this.name + " : ����");
    }

}
