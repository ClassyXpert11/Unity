using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "BronzeCoin")
        {
            coin+=1;
            textCoins.text = coin.ToString();
            Destroy(collision.gameObject);
        } 
        else if (collision.transform.tag == "SilverCoin")
        {
            coin += 2;
            textCoins.text = coin.ToString();
            Destroy(collision.gameObject);
        }
        else if (collision.transform.tag == "GoldCoin")
        {
            coin += 3;
            textCoins.text = coin.ToString();
            Destroy(collision.gameObject);
        }
    }
}
