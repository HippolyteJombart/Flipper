using System.Collections;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    private enum Type {Plane, Truck, Helicopter}
    [SerializeField] private Type attackers;
    [SerializeField] private GameObject bomb;
    [SerializeField] private float bombDelay;

    private void Start()
    {
        if (attackers is Type.Truck || attackers is Type.Helicopter)
        {
            StartCoroutine(DropBombs());
        }
    }
    
    private void OnEnable()
    {
        if (attackers is Type.Truck || attackers is Type.Helicopter)
        {
            StartCoroutine(DropBombs());
        }
    }

    IEnumerator DropBombs()
    {
        while (true)
        {
            yield return new WaitForSeconds(bombDelay); 
            DropOneBombUnder();
        }
    }
    
    public void DropOneBombUnder()
    {
        Instantiate(bomb, new (gameObject.transform.position.x, gameObject.transform.position.y - 0.15f, gameObject.transform.position.z), Quaternion.identity);
    }
}
