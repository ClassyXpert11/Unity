using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject m_menuPanel;
    [SerializeField]
    private GameObject m_controlsPanel;
    private bool m_controlsPanelOpen = false;

    public void ToggleControlPanel()
    {
        if (m_controlsPanelOpen)
        {
            m_menuPanel.SetActive(true);   
            m_controlsPanel.SetActive(false);   
        }
        else
        {
            m_menuPanel.SetActive(false);
            m_controlsPanel.SetActive(true);
        }
        m_controlsPanelOpen = !m_controlsPanelOpen;
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Quit() 
    {  
        Application.Quit();
    }
}
