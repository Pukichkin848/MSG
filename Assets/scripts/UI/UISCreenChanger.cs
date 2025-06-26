using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISCreenChanger : MonoBehaviour
{
    public Button btn; 
    public UIManager manager;
    public int screen;
    void Start()
    {
        btn.onClick.AddListener(o);
    }
    public void o()
    {
        manager.ScreenChanger(screen);
    }
}
