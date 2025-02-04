using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform m_Player;
    public float m_speed;
    public float m_stoppingDistance;
    bool m_PlayerInSight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Player = FindObjectOfType<TopDownCharacterController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_PlayerInSight && Vector2.Distance(transform.position, m_Player.position) >= m_stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, m_Player.position, m_speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

}
