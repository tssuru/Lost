using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    public Canvas mainMenu;
    public Canvas optionsMenu;
    public Canvas aboutMenu;
    public Canvas loading;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        mainMenu.enabled = true;
        optionsMenu.enabled = false;
        aboutMenu.enabled = false;
        loading.enabled = false;
    }

    public void StartButton()
    {
        loading.enabled = true;
        mainMenu.enabled = false;
        SceneManager.LoadScene("Horror_Almost_Done");
    }

    public void OptionsButton()
    {
        mainMenu.enabled = false;
        optionsMenu.enabled = true;
    }

    public void AboutButton()
    {
        mainMenu.enabled = false;
        aboutMenu.enabled = true;
    }

    public void ExitGameButton()
    {
        Application.Quit();
        Debug.Log("App Has Exited");
    }

    public void ReturnToMainMenuButton()
    {
        mainMenu.enabled = true;
        optionsMenu.enabled = false;
        aboutMenu.enabled = false;
    }

    void Update()
    {
    }
}
