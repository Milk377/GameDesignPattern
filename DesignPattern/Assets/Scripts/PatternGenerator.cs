using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PatternAGenerator : UnitGenerator
{
    public override void CreateUnits()
    {
        units.Add(new Marine());
        units.Add(new Marine());
        units.Add(new Marine());
    }
}

class PatternBGenerator : UnitGenerator
{
    public override void CreateUnits()
    {
        units.Add(new Firebat());
        units.Add(new Firebat());
        units.Add(new Firebat());
    }
}
