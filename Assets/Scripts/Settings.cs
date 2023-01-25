using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    private void OnEnable()
    {
        Application.targetFrameRate = 60;
        Input.backButtonLeavesApp = true;   
    }
}
