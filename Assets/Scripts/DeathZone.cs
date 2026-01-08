using System;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private Animation anim;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        VfxManager.Instance.SpawnExplosionCity();
        GameManager.Instance.LoseBall();
        anim.Play();
    }
}
