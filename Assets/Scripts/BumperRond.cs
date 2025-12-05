using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bumper : MonoBehaviour
{
    [SerializeField] private int strength = 300;
    [SerializeField] private int score = 10;
    [SerializeField] private Animation anim;
    private void OnCollisionEnter(Collision other)
    { 
        Vector3 a = transform.position;
        Vector3 b = other.transform.position;
        Vector3 direction = b - a;
        direction = direction.normalized;
        
        other.rigidbody.AddForce(direction * strength);
        
        ScoreManager.Instance.AddScore(score);
        if (anim == null)
        {
            return;
        }
        anim.Play();
    }
}