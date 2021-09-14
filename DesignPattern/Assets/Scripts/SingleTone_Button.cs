using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 신 이동시에도 버튼을 그대로 유지시키고자 함

public class SingleTone_Button : MonoBehaviour
{
    // null 로 초기화
    private static SingleTone_Button _instance = null;

    // get set 메서드는 캡슐화의 기본 
    public static SingleTone_Button getButtonInstance()
    {
        return _instance;
    }

    // 제일 먼저 실행
    private void Awake()
    {
        // null 이라면 (최초 실행)
        if(_instance == null)
        {
            // instance 할당
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
