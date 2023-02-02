using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class importObjectScript : MonoBehaviour

    
{

    string path;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenFileExplorer()
    {
        path = EditorUtility.OpenFilePanel("Fetch for a .3dUnity files", "", "unity3D");
        print(path);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
