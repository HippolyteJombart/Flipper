using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] private GameObject[] avionList;
    [SerializeField] private GameObject[] helicopterList;
    private int indiceAvion = 0;
    private int indiceHelicopter = 0;
    
    public int cityLife = 6;
    
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

    public void LoseBall()
    {
        cityLife --;
        if (cityLife <= 0)
        {
            Time.timeScale = 0;
            MenuManager.Instance.OpenCloseDieMenu();
        }
        else
        {
            VfxManager.Instance.CityExplosion(cityLife);
        }
    }
    
    public void BombCollision(string tag)
    {
        if (tag == "Avion")
        {
            indiceAvion += 1;
            if (indiceAvion < avionList.Length)
            {
                avionList[indiceAvion].SetActive(true);
            }
        }
        else if (tag == "Helicopter")
        {
            indiceHelicopter += 1;
            if (indiceHelicopter > helicopterList.Length)
            {
                helicopterList[indiceHelicopter].SetActive(true);
            }
        }
    }
}
