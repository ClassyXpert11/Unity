using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishLevelScript : MonoBehaviour
{
    public TextMeshProUGUI textCoins;
    private void Start()
    {
        textCoins.text = ScoreManager.score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(2);
            //textCoins.text = CoinPickup.score.ToString();
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
