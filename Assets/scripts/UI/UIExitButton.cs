using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIExitButton : MonoBehaviour
{
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(Exit);
    }
    public void Exit ()
    {
        Application.Quit();
    }

}
