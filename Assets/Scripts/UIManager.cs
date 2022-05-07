using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManager : MonoBehaviour
{
    

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
   

    // Update is called once per frame
    void Update()
    {

    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
