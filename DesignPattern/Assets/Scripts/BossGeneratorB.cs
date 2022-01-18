using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BossGeneratorB : BossFactory
{
    public BossType type = BossType.Type1_Normal;
    public GameObject _normalBoss;
    public GameObject _eventBoss;

    public override void CreateBoss(Transform tran)
    {
        if(type == BossType.Type1_Normal)
        {
            GameObject boss = Instantiate(_normalBoss) as GameObject;
            boss.transform.position = tran.position;
            boss.transform.localRotation = tran.localRotation;

        }
        else if(type == BossType.Type1_Unique)
        {
            GameObject boss = Instantiate(_eventBoss) as GameObject;
            boss.transform.position = tran.position;
            boss.transform.localRotation = tran.localRotation;


        }
    }
}
