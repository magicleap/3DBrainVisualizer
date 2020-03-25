using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnHome_Complete : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void Update()
    {
        
    }
    public void ExitApp()
    {
#if UNITY_EDITOR
        Debug.Log("Exit to Home: Unity Editor Quit");
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
