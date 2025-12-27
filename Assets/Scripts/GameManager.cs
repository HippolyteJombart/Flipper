using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] private GameObject[] avionList;
    [SerializeField] private GameObject[] helicopterList;
    [SerializeField] private GameObject[] truckList;
    private int indiceAvion = 0;
    private int indiceHelicopter = 0;
    private int indiceTruck = 0;
    
    public int cityLife = 6;
    [SerializeField] private TextMeshProUGUI textLife;
    
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

    public void Start()
    {
        foreach (GameObject avion in avionList)
        {
            avion.SetActive(false);
        }
        foreach (GameObject helico in helicopterList)
        {
            helico.SetActive(false);
        }
        avionList[0].SetActive(true);
        helicopterList[0].SetActive(true);
    }
    
    public void LoseBall()
    {
        cityLife --;
        if (cityLife <= 0)
        {
            MenuManager.Instance.OpenCloseDieMenu();
        }
        else
        {
            VfxManager.Instance.CityExplosion(cityLife);
            textLife.text = cityLife.ToString();
        }
    }
    
    public void BombCollision(string tag)
    {
        if (tag == "Avion")
        {
            indiceAvion++;
            if (indiceAvion < avionList.Length)
            {
                avionList[indiceAvion].SetActive(true);
            }
        }
        else if (tag == "Helicopter")
        {
            indiceHelicopter++;
            if (indiceHelicopter < helicopterList.Length)
            {
                helicopterList[indiceHelicopter].SetActive(true);
            }
        }
        else if (tag == "Truck")
        {
            indiceTruck++;
        }

        if (indiceHelicopter == helicopterList.Length && indiceAvion == avionList.Length && indiceTruck == truckList.Length)
        {
            MenuManager.Instance.OpenCloseWinMenu();
        }
    }
}
