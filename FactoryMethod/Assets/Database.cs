using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Database 
{
    public string name;
    public double rows;

    public abstract void ConnectDatabase();

    public void InsertData()
    {
        Debug.Log(name + " 에 데이터를 추가했습니다.");
    }

    public void SelectData()
    {
        Debug.Log(name + "에 데이터를 " + rows + "게 조회 했습니다.");
    }
}


