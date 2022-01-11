using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebat : Unit
{
    private void Start()
    {
        Debug.Log("Firebat »ý¼º");

    }

    public override void Move()
    {
        Debug.Log("Firebat Move");
    }

    public override void Attack()
    {
        Debug.Log("Firebat Attack");
    }
}
