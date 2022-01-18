using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BossType
{
    Type1_Normal,
    Type1_Unique,
    Type2_Normal,
    Type2_Unique
}

// Boss �߻� Ŭ������ MonoBehaviour�� ��� �޾Ƶ� �Ǵ°�?
// ������ Boss�� ��ӹ��� ���������� Boss�� �����ϴ� Ŭ�������� �����ؾ� ���� ������?


abstract class Boss : MonoBehaviour
{
    protected BossType type;
    protected int hp;
    protected int exp;

    public abstract void Attack();
    public abstract void DropItem(string name);


  
}
