using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unit을 상속받는 Marine 도 public 이 아니라 private으로.

class Marine : Unit
{

    //private void Start()
    //{
    //    Debug.Log("Marine 생성");
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

        Debug.Log(this.name + " : 생성");
    }

    public override void Attack()
    {
        Debug.Log(this.name + " : 공격");
    }

}
