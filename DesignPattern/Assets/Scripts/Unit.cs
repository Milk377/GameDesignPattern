using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Marine,
    Firebat
}
// Unit �߻�Ŭ����
// private ���� ?
// MonoBehaviour �� ��ӹ��� �ʰ�?
abstract class Unit 
{
    protected UnitType type;
    protected string name;
    protected int hp;
    protected int exp;
    public abstract void Attack();
    


}
