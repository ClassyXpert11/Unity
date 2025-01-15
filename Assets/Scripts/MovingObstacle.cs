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
        Vector2 position = transform.position;
        position.y = transform.position.y + 0.1f;
        transform.position = position;
    }
}
