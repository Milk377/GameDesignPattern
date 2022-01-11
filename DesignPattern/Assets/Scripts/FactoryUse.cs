using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUse : MonoBehaviour
{
    FactoryUnit factory = null;
    GameObject unit1 = null;
    GameObject unit2 = null;
    GameObject unit3 = null;

    private void Start()
    {
        factory = GetComponent<FactoryUnit>();

        unit1 = factory.createUnit(UnitType.Marine);
        unit2 = factory.createUnit(UnitType.Firebat);

    }

    IEnumerator UnitAction()
    {
        yield return new WaitForSeconds(0.2f);

        unit1.GetComponent<Unit>().Move();
        unit2.GetComponent<Unit>().Move();

    }
}
