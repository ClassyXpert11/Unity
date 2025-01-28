using System.Collections;
using UnityEngine;

public class ExplosionTest : MonoBehaviour
{
    [SerializeField, Range(0.01f, 1f)] private float m_explosionFrequency = 0.1f;
    [SerializeField, Range(0.5f, 4f)] private float m_explosionRadius = 0.1f;

    private void Awake()
    {
        StartCoroutine(ExplosionSpawner());
    }

    private IEnumerator ExplosionSpawner()
    {
        while (true)
        {
            // wait for a moment
            yield return new WaitForSeconds(m_explosionFrequency);

            // find the positions to spawn the explosion at.
            Vector3 explosionPos = transform.position;
            explosionPos += (Vector3)UnityEngine.Random.insideUnitCircle.normalized * m_explosionRadius;
            
            // spawn an explosion
            VFXManager.CreateExplosion(explosionPos);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
