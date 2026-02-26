using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour
{
    public Slider _Loading;

    private void Start()
    {
        Loading(1);
    }


    public void Loading(int SceneIndex)
    {
        StartCoroutine(levelLoader( SceneIndex));
    }

    IEnumerator levelLoader(int SceneIndex)
    {
        AsyncOperation Operation   = SceneManager.LoadSceneAsync(SceneIndex);

        while (!Operation.isDone )
        {
            float Progress = Mathf.Clamp01(Operation.progress / 0.9f);
            _Loading.value = Progress;
        }
        yield return null;
    }



}
