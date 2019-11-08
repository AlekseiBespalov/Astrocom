using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplicationManager : MonoBehaviour {

    public GameObject _loadingIcon;
    public float _oneStepAngle;

    AsyncOperation async;

    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void LoadAstronomy()
    {
        
        StartCoroutine(LoadingAsync());
    }

    IEnumerator LoadingAsync()
    {
        _loadingIcon.SetActive(true);
        async = SceneManager.LoadSceneAsync(1);
        async.allowSceneActivation = false;
        while(async.isDone == false)
        {
            _loadingIcon.transform.Rotate(0, 0, -_oneStepAngle);

            if(async.progress == 0.9f)
            {
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

	public void Quit () 
	{
		Application.Quit();
	}
}
