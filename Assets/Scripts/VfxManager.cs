using UnityEngine;

public class VfxManager : MonoBehaviour
{
    public static VfxManager Instance;
    public GameObject[] explosionList;
    [SerializeField] private GameObject explosion;
    [SerializeField] private GameObject explosionCity;
    [SerializeField] private GameObject explosionLocationCity;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CityExplosion(int lifePoint)
    {
        
        if (lifePoint <= explosionList.Length)
        {
            explosionList[lifePoint-1].SetActive(true);
        }
    }

    public void SpawnExplosion(GameObject exploded)
    {
        Instantiate(explosion, exploded.transform.position, Quaternion.identity, GameManager.Instance.gameObject.transform);
    }
    
    public void SpawnExplosionCity()
    {
        Instantiate(explosionCity, explosionLocationCity.transform.position, Quaternion.identity, GameManager.Instance.gameObject.transform);
    }
}
