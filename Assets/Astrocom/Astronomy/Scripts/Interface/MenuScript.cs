using UnityEngine;

public class MenuScript : MonoBehaviour
{
    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    public void ExitProgram()
    {
        Application.Quit();
    }
}