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
        Debug.Log(name + " �� �����͸� �߰��߽��ϴ�.");
    }

    public void SelectData()
    {
        Debug.Log(name + "�� �����͸� " + rows + "�� ��ȸ �߽��ϴ�.");
    }
}


