using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishLevelScript : MonoBehaviour
{
    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
