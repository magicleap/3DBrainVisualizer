using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnHome_Complete : MonoBehaviour
{
    //Quits application or stops playmode in Unity Editor
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
