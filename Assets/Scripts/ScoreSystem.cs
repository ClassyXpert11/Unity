using UnityEngine;
using UnityEngine.Events;

public class ScoreSystem : MonoBehaviour
{
    // the current score of the player
    public int m_score;
    public UnityEvent onClick;

    /// <summary>
    /// Method to add a given amount of score to the player.
    /// </summary>
    /// <param name="scoreToAdd">The amount of score to be added.</param>
    public void AddScore(int scoreToAdd)
    {
        // Increment the player score by the amount to add.
        m_score += scoreToAdd;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onClick.AddListener(handleOnClick);
    }

    // Update is called once per frame
    public void Update()
    {
        onClick.Invoke();
    }
    public void handleOnClick()
    {
       // m_score += 5;
    }
}