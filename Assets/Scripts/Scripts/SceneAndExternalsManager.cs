using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneAndExternalsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OpenWebsite(string url)
    {
        Application.OpenURL(url);
    }
}
