using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseGenerator : DatabaseFactory
{
    public DBType dbType = DBType.MySQL;

    public override Database MakeDatabase()
    {
        if(dbType == DBType.MySQL)
        {
            Debug.Log("MySQL use");
            return new MySQL();
        }
        else
        {
            return null;
        }
    }



}
