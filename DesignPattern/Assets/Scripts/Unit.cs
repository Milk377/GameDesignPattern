using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Marine,
    Firebat
}
// Unit 추상클래스
// private 으로 ?
// MonoBehaviour 을 상속받지 않고?
abstract class Unit 
{
    protected UnitType type;
    protected string name;
    protected int hp;
    protected int exp;
    public abstract void Attack();
    


}
