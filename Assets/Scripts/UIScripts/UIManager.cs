using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    GameObject MainMenu;
    GameObject StartPanel;
    GameObject SettingsPanel;
    GameObject CreditsPanel;
    GameObject ExitPanel;
    Controller_1 controller_1;
    void Start()
    {
        controller_1 = GameObject.FindGameObjectWithTag("MainMenu").GetComponent<Controller_1>();

        MainMenu = GameObject.FindGameObjectWithTag("MainMenu");
        StartPanel = GameObject.FindGameObjectWithTag("StartPanel");
        SettingsPanel = GameObject.FindGameObjectWithTag("SettingsPanel");
        CreditsPanel = GameObject.FindGameObjectWithTag("CreditsPanel");
        ExitPanel = GameObject.FindGameObjectWithTag("ExitPanel");

        controller_1.inicialized();
        int n = 0;
        ScreenManagment(ref n);
    }

    public void ScreenManagment(ref int parameter)
    {
        print("Se abrira la pantalla del parametro" + parameter);
        TurnOffPanles();
        switch (parameter) 
        {
            case 0: MainMenu.SetActive(true); break;
            case 1: StartPanel.SetActive(true); break;
            case 2: SettingsPanel.SetActive(true); break;
            case 3: CreditsPanel.SetActive(true); break;
            case 4: ExitPanel.SetActive(true); break;
            default: print("Ventana no existente" + parameter); break;
        }
    }

    public void TurnOffPanles()
    {
        MainMenu.SetActive(false);
        StartPanel.SetActive(false);
        SettingsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        ExitPanel.SetActive(false);
    }


}
