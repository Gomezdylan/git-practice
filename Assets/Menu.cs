using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject helpPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene("Pong");
    }

    public void ShowHelp()
    {
        helpPanel.SetActive(true);
    }

    public void HideHelp()
    {
        helpPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game"); // for the console
    }
}
