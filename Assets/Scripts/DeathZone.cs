using System;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        VfxManager.Instance.SpawnExplosionCity();
        GameManager.Instance.LoseBall();
    }
}
