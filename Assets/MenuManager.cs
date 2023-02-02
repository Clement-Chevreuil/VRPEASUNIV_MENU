using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update

    string path;
    public void OpenFileExplorer() 
    {

        Debug.Log("exploirer clicked");
        path = EditorUtility.OpenFilePanel("Fetch for a .3dUnity files", "", "unity3D");

    }

    public void ExitMenu()
    {
        Debug.Log("exit clicked");
        Application.Quit();
    }
        
}
