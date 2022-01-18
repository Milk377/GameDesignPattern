using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("RotateUp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RotateUp()
    {
        while (true)
        {
            transform.Rotate(10.0f * Vector3.up);

            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator RotateForward()
    {
        while (true)
        {
            transform.Rotate(10.0f * Vector3.forward);

            yield return new WaitForSeconds(0.5f);
        }

    }



}
