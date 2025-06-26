using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject[] Screens;
    // Start is called before the first frame update
    void Start()
    {
        ScreenChanger(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ScreenChanger(0);
            Test("לאלאללאא");
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            ScreenChanger(1);
            Test("‎תת");
        }
    }
    public void ScreenChanger(int ScreenNumber)
    {
        foreach (GameObject screen in Screens)
        {
            screen.SetActive(false);

        }
        Screens[ScreenNumber].SetActive(true);

    }
    public void Test(string Text)
    {
        print(Text);
    }
}

