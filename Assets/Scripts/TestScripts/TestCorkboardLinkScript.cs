using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCorkboardLinkScript : MonoBehaviour
{
    public string myUrl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadWebPage()
    {
        Debug.Log(myUrl);
        Application.OpenURL(myUrl);
    }

    public void FinishedEditing(InputField myInput)
    {
        myUrl = myInput.text;
            //.ToString(); 
    }
}
