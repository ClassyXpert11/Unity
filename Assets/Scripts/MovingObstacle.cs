using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] private Transform m_startWaypoint;
    [SerializeField] private Transform m_endWaypoint;
    [SerializeField] private float m_speed = 5;

    private Transform m_target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_target = m_startWaypoint;
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 direction = m_target.position - transform.position;
       transform.Translate(direction * m_speed * Time.deltaTime);
    }

    void ChangeTarget()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MovingObstackeWaypoint"))
        {
            ChangeTarget();
        }
    }
}
