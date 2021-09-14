using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTone_AudioManager : MonoBehaviour
{
    static SingleTone_AudioManager _instance = null;

    public static SingleTone_AudioManager Instance()
    {
        return _instance;
    }

    private void Start()
    {
        // 만약 _instance 가 한번도 생성되지 않아 null 이라면
        // this , 즉 현재 객체를 인스턴스화 시킨다. 
        if (_instance == null)
            _instance = this;
    }

    public void PlaySound(AudioClip clip)
    {
        Debug.Log("play sound");
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

}
