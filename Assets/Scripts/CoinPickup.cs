using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    public float coin = 0;
    public static float score = 0;

    public TextMeshProUGUI textCoins;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "BronzeCoin")
        {
            coin+=1;
            ScoreManager.score = coin;
            textCoins.text = coin.ToString();
            Destroy(collision.gameObject);
        } 
        else if (collision.transform.tag == "SilverCoin")
        {
            coin += 2;
            ScoreManager.score = coin;
            textCoins.text = coin.ToString();
            Destroy(collision.gameObject);
        }
        else if (collision.transform.tag == "GoldCoin")
        {
            coin += 3;
            ScoreManager.score = coin;
            textCoins.text = coin.ToString();
            Destroy(collision.gameObject);
        }
    }
}
