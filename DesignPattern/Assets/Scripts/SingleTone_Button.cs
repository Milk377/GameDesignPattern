using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �� �̵��ÿ��� ��ư�� �״�� ������Ű���� ��

public class SingleTone_Button : MonoBehaviour
{
    // null �� �ʱ�ȭ
    private static SingleTone_Button _instance = null;

    // get set �޼���� ĸ��ȭ�� �⺻ 
    public static SingleTone_Button getButtonInstance()
    {
        return _instance;
    }

    // ���� ���� ����
    private void Awake()
    {
        // null �̶�� (���� ����)
        if(_instance == null)
        {
            // instance �Ҵ�
            Debug.Log("Button instance is null. ");
            _instance = this;
            DontDestroyOnLoad(this.gameObject);

            Debug.Log("Complete to set instance Button");


        }
        else
        {
            if(this != _instance)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
