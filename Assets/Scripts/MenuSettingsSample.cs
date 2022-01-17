using UnityEngine;

public class MenuSettingsSample : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsPanel;

    void Start()
    {
        settingsPanel.SetActive(false);
    }

    public void Settings()
    {
        settingsPanel.SetActive(!settingsPanel.activeInHierarchy);
    }

    public void Exit()
    {
        Debug.Log("Closing Application");
        Application.Quit();
    }
}
