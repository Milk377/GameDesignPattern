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
        // ���� _instance �� �ѹ��� �������� �ʾ� null �̶��
        // this , �� ���� ��ü�� �ν��Ͻ�ȭ ��Ų��. 
        if (_instance == null)
            _instance = this;
    }

    public void PlaySound(AudioClip clip)
    {
        Debug.Log("play sound");
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

}
