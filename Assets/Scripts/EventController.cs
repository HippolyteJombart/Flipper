using UnityEngine;
using UnityEngine.Events;

public class EventController : MonoBehaviour
{
    [SerializeField] private UnityEvent onTriggerEnterEvent;

    public void OnTriggerEnter(Collider other)
    {
        onTriggerEnterEvent.Invoke();
    }
}
