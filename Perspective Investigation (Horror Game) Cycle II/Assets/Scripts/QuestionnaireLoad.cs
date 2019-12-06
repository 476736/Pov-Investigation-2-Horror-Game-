using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionnaireLoad : MonoBehaviour
{
   public void LoadScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
    private void OnTriggerEnter(Collider scareTrigger)
    {
        SceneManager.LoadScene("Main Menu");
    }

}
