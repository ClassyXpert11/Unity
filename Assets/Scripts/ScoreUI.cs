using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    // a reference to the score system
    public ScoreSystem m_scoreSystem;

    // a reference to the UI label - this will be updated every frame.
    public TMPro.TextMeshPro m_uiLabel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set the text to "score: {score}"
        m_uiLabel.text = "Score " + m_scoreSystem.m_score;
    }
}
