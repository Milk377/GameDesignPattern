using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTone_SoundPlay : MonoBehaviour
{
    //오디오 클립 선언
    public AudioClip audio1;

    // OnCollisionEnter 의 매개변수는 Collision 형 변수가 자동,고정이다.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter");
        SingleTone_AudioManager.Instance().PlaySound(audio1);

        Destroy(this.gameObject);
    }
}
