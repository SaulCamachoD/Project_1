using UnityEngine;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour
{
    GameObject PauseMenu;
    GameObject GameOverMenu;
    Controller_P controllerp;
    Controller_GO controller_Go;
    void Start()
    {
        controller_Go = GameObject.FindGameObjectWithTag("GameOverMenu").GetComponent<Controller_GO>();
        controllerp = GameObject.FindGameObjectWithTag("PauseMenu").GetComponent<Controller_P>();

        PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        GameOverMenu = GameObject.FindGameObjectWithTag("GameOverMenu");
            
        PauseMenu.SetActive(false);
        GameOverMenu.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            ActivationPauseMenu();
        }
        
        if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("MainScene");
        }
        
        if (Input.GetKey(KeyCode.L))
        {
            ActivationGameOverMenu();
        }


    }
    public void desactivationPauseMenu(ref int controllerparameter)
    {
        if (controllerparameter == 0)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 0f;
        }
        
    }

    public void ActivationPauseMenu()
    {
        PauseMenu.SetActive(true);
        controllerp.InicializedCP();
        Time.timeScale = 1.0f;
    }

    public void ActivationGameOverMenu()
    {

        GameOverMenu.SetActive(true);
        controller_Go.InicializedControllerGo();
    }

    public void ActionGameOverMenu(ref int controllerparameter)
    {
            if (controllerparameter == 0)
            {
                SceneManager.LoadScene("UIScene");
            }
            
            if (controllerparameter == 1)
            {
            SceneManager.LoadScene("MainScene");
        }
    }
}
