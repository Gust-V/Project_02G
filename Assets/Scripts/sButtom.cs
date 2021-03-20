using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class sButtom : MonoBehaviour
{
    public void Touch()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "ScHome")
        {
            string nameButton = EventSystem.current.currentSelectedGameObject.name;

            if (nameButton == "Bt00_Qt")
            {
                SceneManager.LoadScene("ScQuarto");
            }
            else if (nameButton == "Bt01_Sl")
            {
                SceneManager.LoadScene("ScSala");
            }
            else if(nameButton == "Bt02_Bn")
            {
                SceneManager.LoadScene("ScBanheiro");
            }
            else if (nameButton == "Bt03_Cz")
            {
                SceneManager.LoadScene("ScCozinha");
            }
        }
        else if (currentSceneName != "ScHome" && currentSceneName != "ScMenuP")
        {
            SceneManager.LoadScene("ScHome");
        }
        else if (currentSceneName == "ScMenuP")
        {
            SceneManager.LoadScene("ScHome");
        }


    }
}

