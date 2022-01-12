using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFactoryMethod : MonoBehaviour
{
    DatabaseFactory factory = null;
    Database db = null;
    // Start is called before the first frame update
    void Start()
    {
        factory = GetComponent<DatabaseGenerator>();

        db = factory.MakeDatabase();
        db.ConnectDatabase();
        db.InsertData();
        db.SelectData();
    }

}
