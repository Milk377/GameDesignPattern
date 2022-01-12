using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Firebat : Unit
{
    //
    //protected UnitType type;
    //protected string name;
    //protected int hp;
    //protected int exp;
    //public abstract void Attack();


    public Firebat()
    {
        type = UnitType.Marine;
        name = "Firebat";
        hp = 100;
        exp = 50;

        Debug.Log(this.name + " : 积己");
    }

    public override void Attack()
    {
        Debug.Log(this.name + " : 傍拜");
    }


}
//{
//    private void Start()
//    {
//        Debug.Log("Firebat 积己");

//    }

//    public override void Move()
//    {
//        Debug.Log("Firebat Move");
//    }

//    public override void Attack()
//    {
//        Debug.Log("Firebat Attack");
//    }

