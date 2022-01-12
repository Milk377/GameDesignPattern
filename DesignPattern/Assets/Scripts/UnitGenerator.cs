using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//이 추상 클래스를 이용해
//구상 클래스를 만드는게, Pattern Generator이다.


abstract class UnitGenerator 
{
    // Unit 자료형의 List를 생성
    public List<Unit> units = new List<Unit>();

    // 생각해보니 abstract 클래스인데 선언, 생성자, 함수 구현까지 해둠
    // 추상메서드도 선언하고있고.
    // 리스트를 반환
    public List<Unit> getUnits()
    {
        return units;
    }

    public abstract void CreateUnits();


}
