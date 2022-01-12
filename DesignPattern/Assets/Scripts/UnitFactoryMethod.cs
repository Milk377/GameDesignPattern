using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactoryMethod : MonoBehaviour
{
    UnitGenerator[] unitGenerators = null;

    private void Start()
    {
        // UnitGenerator 자료형의 크기가2인 배열 생성
        unitGenerators = new UnitGenerator[2];

        unitGenerators[0] = new PatternAGenerator();
        unitGenerators[1] = new PatternBGenerator();

    }

    public void DoMakeTypeA()
    {
        unitGenerators[0].CreateUnits();

        List<Unit> units = unitGenerators[0].getUnits();
        
        foreach (Unit unit in units)
        {
            unit.Attack();
        }

    }

    public void DoMakeTypeB()
    {
        unitGenerators[1].CreateUnits();

        List<Unit> units = unitGenerators[1].getUnits();

        foreach (Unit unit in units)
        {
            unit.Attack();
        }
    }

}
