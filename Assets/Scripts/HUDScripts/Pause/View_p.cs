using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_p : MonoBehaviour
{
    Controller_P controllerp;
    public void InicializedVP()
    {
        controllerp = GameObject.FindGameObjectWithTag("PauseMenu").GetComponent<Controller_P>();
    }

    public void OnclickPauseReturn(int parameter)
    {
        controllerp.Event(ref parameter);
    }
}
