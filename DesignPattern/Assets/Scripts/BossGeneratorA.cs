using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Boss Factory 추상 클래스를 구현하는
// 구상 클래스 BossGenerator

class BossGeneratorA : BossFactory
{
    public BossType type = BossType.Type1_Normal;
    public GameObject _normalBoss;
    public GameObject _eventBoss;

    public override void CreateBoss(Transform tran)
    {
        GameObject boss1 = Instantiate(_normalBoss) as GameObject;
        boss1.transform.position = tran.position;
        boss1.transform.localRotation = tran.localRotation;

        GameObject boss2 = Instantiate(_eventBoss) as GameObject;
        boss2.transform.position = tran.position + new Vector3(1,1,1);
        boss2.transform.localRotation = tran.localRotation;

        GameObject boss3 = Instantiate(_eventBoss) as GameObject;
        boss3.transform.position = tran.position + new Vector3(3, 3, 1);
        boss3.transform.localRotation = tran.localRotation;
    }
}
