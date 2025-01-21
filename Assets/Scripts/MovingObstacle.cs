using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] private Transform m_startWaypoint;
    [SerializeField] private Transform m_endWaypoint;
    [SerializeField] private float m_speed = 5;
    Vector2 direction;

    private Transform m_target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_target = m_startWaypoint;
        direction = m_target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(direction * m_speed * Time.deltaTime);
    }

    void ChangeTarget()
    {
        if (m_target == m_startWaypoint)
            m_target = m_endWaypoint;
        else
            m_target = m_startWaypoint;

        direction = m_target.position - transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "MovingObstacleWaypoint")
        {
            ChangeTarget();
        }
    }
}
