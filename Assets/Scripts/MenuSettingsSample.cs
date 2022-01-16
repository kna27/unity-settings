using UnityEngine;

public class MenuSettingsSample : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsPanel;

    void Start()
    {
        settingsPanel.SetActive(false);
    }

    public void Play()
    {
        Debug.Log("Play Button Pressed!");
    }

    public void Settings()
    {
        settingsPanel.SetActive(!settingsPanel.activeInHierarchy);
    }

    public void Exit()
    {
        Debug.Log("Closing application");
        Application.Quit();
    }
}
