using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_1 : MonoBehaviour
{
    UIManager manager;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("ManagerMenu").GetComponent<UIManager>();
    }

    public void Event(ref int controllerEvent)
    {
        manager.ScreenManagment(ref controllerEvent);   
    }


}