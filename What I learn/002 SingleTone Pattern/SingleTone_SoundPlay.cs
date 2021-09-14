using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTone_SoundPlay : MonoBehaviour
{
    //����� Ŭ�� ����
    public AudioClip audio1;

    // OnCollisionEnter �� �Ű������� Collision �� ������ �ڵ�,�����̴�.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter");
        SingleTone_AudioManager.Instance().PlaySound(audio1);

        Destroy(this.gameObject);
    }
}
