using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�� �߻� Ŭ������ �̿���
//���� Ŭ������ ����°�, Pattern Generator�̴�.


abstract class UnitGenerator 
{
    // Unit �ڷ����� List�� ����
    public List<Unit> units = new List<Unit>();

    // �����غ��� abstract Ŭ�����ε� ����, ������, �Լ� �������� �ص�
    // �߻�޼��嵵 �����ϰ��ְ�.
    // ����Ʈ�� ��ȯ
    public List<Unit> getUnits()
    {
        return units;
    }

    public abstract void CreateUnits();


}
