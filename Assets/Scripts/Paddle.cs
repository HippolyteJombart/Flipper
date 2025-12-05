using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private HingeJoint hingeJoint;
    [SerializeField] private KeyCode key = KeyCode.Space;
    [SerializeField] public float targetPosition = 75f;
    [SerializeField] public float originPosition;

    private JointSpring jointSpring;

    private void Start()
    {
        jointSpring = hingeJoint.spring;
    }

    private void Update()
    {
        if (Input.GetKey(key))
        {
            jointSpring.targetPosition = targetPosition;
        }
        else
        {
            jointSpring.targetPosition = originPosition;
        }

        hingeJoint.spring = jointSpring;
    }
}
