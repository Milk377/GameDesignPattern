using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySQL : Database
{
    public MySQL()
    {
        name = "MySQL";
        rows = 20;
    }

    public override void ConnectDatabase()
    {
        Debug.Log(name + " 에 접속했습니다.");
    }
}
