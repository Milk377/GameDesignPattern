using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine : Unit
{
    private void Start()
    {
        Debug.Log("Marine »ý¼º");
    }

    public override void Move()
    {
        Debug.Log("Marine Move");
    }

    public override void Attack()
    {
        Debug.Log("Marine Attack");
    }

}
