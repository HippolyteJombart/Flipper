using UnityEngine;

public class VfxManager : MonoBehaviour
{
    public static VfxManager Instance;
    public GameObject[] explosionList;
    
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
    
}
