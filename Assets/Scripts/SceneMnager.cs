using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMnager : MonoBehaviour
{






    public void Play()
    {
        SceneManager.LoadScene(2);
    }
     public void HomeScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
