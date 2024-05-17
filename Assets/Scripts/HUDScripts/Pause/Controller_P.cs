using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_P : MonoBehaviour
{
    HudManager hudManager;
    View_p viewp;
    public void InicializedCP()
    {
        hudManager = GameObject.FindGameObjectWithTag("HudManager").GetComponent<HudManager>();
        viewp = GameObject.FindGameObjectWithTag("PauseMenu").GetComponent<View_p>();
        viewp.InicializedVP();
    }  

    public void Event(ref int ControllerEvent)
    {
        hudManager.desactivationPauseMenu(ref ControllerEvent);
    }
}
