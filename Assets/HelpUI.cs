using UnityEngine;

public class HelpUI : MonoBehaviour
{

    public GameObject helpPanel;

   
    public void ShowHelp()
    {
        helpPanel.SetActive(true);
    }

    public void HideHelp()
    {
        helpPanel.SetActive(false);
    }
}
