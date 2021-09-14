using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// æ¿ ¿Ãµø 
using UnityEngine.SceneManagement;


public class SingleTone_MoveScene : MonoBehaviour
{
    public void SceneTrans1to2()
    {
        Debug.Log("Scene move 1 to 2");
        SceneManager.LoadScene("scene2");
    }

    public void SceneTrans2to3()
    {
        Debug.Log("Scene move 2 to 3");
        SceneManager.LoadScene("scene3");
    }



}
