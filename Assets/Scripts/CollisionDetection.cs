using System;
using System.Globalization;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            GameManager.Instance.BombCollision(tag);
            ScoreManager.Instance.AddScore(500);
            VfxManager.Instance.SpawnExplosion(gameObject);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
