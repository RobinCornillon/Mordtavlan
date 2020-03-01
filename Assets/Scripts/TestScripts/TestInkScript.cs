using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class TestInkScript : MonoBehaviour
{
    public TextAsset inkJson;
    private Story story;
    public Text computerTextBox, playerTextBox;
    public Button option1, option2, option3;


    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJson.text);
        computerTextBox.text = NextStorybit();
        SetOptions();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public string NextStorybit()
    {
        string text = "";

        if (story.canContinue)
        {
            text = story.ContinueMaximally();
        }

        return text;
    }

    public void SetOptions()
    {
        int i = 0;
        foreach (Choice choise in story.currentChoices)
        {
            if (i == 0)
            {
                option1.GetComponentInChildren<Text>().text = choise.text;
            }
            else if (i == 1)
            {               
                    option2.GetComponentInChildren<Text>().text = choise.text;               
            }
            else if (i == 2)
            {                
                    option3.GetComponentInChildren<Text>().text = choise.text;              
            }
            i++;
        }
    }

    public void SelectionMade(int choise)
    {
        story.ChooseChoiceIndex(choise);
        playerTextBox.text = story.ContinueMaximally();
    }
}
