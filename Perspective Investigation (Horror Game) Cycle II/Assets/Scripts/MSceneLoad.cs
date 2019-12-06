using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MSceneLoad : MonoBehaviour
{ 
    public void LoadScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
