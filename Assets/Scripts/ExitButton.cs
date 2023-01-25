using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ExitButton : MonoBehaviour
{

    private void OnEnable()
    {
        VisualElement exitButton = GetComponent<UIDocument>().rootVisualElement.Q("GoHome");

        exitButton.RegisterCallback<MouseDownEvent>(OnExitClicked);
    }


    void OnExitClicked(MouseDownEvent e)
    {
        Application.Quit();
    }
}
