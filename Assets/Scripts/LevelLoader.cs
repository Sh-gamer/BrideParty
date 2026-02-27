using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour
{
    public Slider _Loading;
    public bool _LoadingEnabled = true;
    private void Start()
    {
        Loading(1);
    }


    public void Loading(int SceneIndex)
    {
        StartCoroutine(levelLoader( SceneIndex));
       // _LoadingEnabled = false;
    }

    IEnumerator levelLoader(int SceneIndex)
    {
       // if (_LoadingEnabled)
       // {

        AsyncOperation Operation   = SceneManager.LoadSceneAsync(SceneIndex);

        while (!Operation.isDone )
        {
              float Progress = Mathf.Clamp01(Operation.progress / 0.9f);
             _Loading.value = Progress;
          //  Debug.Log(Operation.progress);

        yield return null;
        }



        //}
    }



}
