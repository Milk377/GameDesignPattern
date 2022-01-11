using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unit 추상클래스
public abstract class Unit : MonoBehaviour
{
    // 추상 메서드. 각 유닛이 설정한다.
    public abstract void Move();
    public abstract void Attack();


}
