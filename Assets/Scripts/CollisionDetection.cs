using System;
using System.Globalization;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    [SerializeField] private GameObject explosionFumee;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            GameManager.Instance.BombCollision(tag);
            ScoreManager.Instance.AddScore(500);
            Instantiate(explosion, transform.position, Quaternion.identity, GameManager.Instance.gameObject.transform);
            Instantiate(explosionFumee, transform.position, Quaternion.identity, GameManager.Instance.gameObject.transform);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
