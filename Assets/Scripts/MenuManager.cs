using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private KeyCode menuKey = KeyCode.Escape;
    [SerializeField] private GameObject dieMenu;
    [SerializeField] private GameObject winMenu;

    
    public static MenuManager Instance;
    
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
    
    private void Start()
    {
        if(pauseMenu!=null){ pauseMenu.SetActive(false);}
        if(dieMenu!=null){ dieMenu.SetActive(false);}
        if(winMenu!=null){ winMenu.SetActive(false);}
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(menuKey))
        {
            if(pauseMenu!=null)
            {
                OpenClosePauseMenu();
            }
        }
    }
    
    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        
    }

    public void GoNextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    
    public void OpenClosePauseMenu()
    {
        if (dieMenu.activeSelf)
        {
            return;
        }
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        if(pauseMenu.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }

    public void OpenCloseDieMenu()
    {
        
        dieMenu.SetActive(!dieMenu.activeSelf);
        if(dieMenu.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    
    public void OpenCloseWinMenu()
    {
        
        winMenu.SetActive(!winMenu.activeSelf);
        if(winMenu.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}