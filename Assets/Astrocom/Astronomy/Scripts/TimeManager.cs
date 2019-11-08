using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text speedRateText;
    public float CurrentSpeedRate = 1;

    private float previouslSpeedRate = 1;
    private bool paused = false;

    public float minSpeedRate = 0.033f;
    public float maxSpeedRate = 32f;

    void Start()
    {
        CurrentSpeedRate = 1;
    }
    
    public void SlowDownRate()
    {
        if(CurrentSpeedRate <= minSpeedRate)
        {
            return;
        }
        CurrentSpeedRate /= 2;
        previouslSpeedRate = CurrentSpeedRate;
        DoSlowMotion();
    }

    public void IncreaseTimeRate()
    {
        if(CurrentSpeedRate >= maxSpeedRate)
        {
            return;
        }
        CurrentSpeedRate *= 2;
        previouslSpeedRate = CurrentSpeedRate;
        DoSlowMotion();
    }

    public void DoSlowMotion()
    {
        Time.timeScale = CurrentSpeedRate;
        Time.fixedDeltaTime = Time.timeScale * .02f; //for smooth slowmotion
        SetSpeedRateText();
    }

    void SetSpeedRateText()
    {
        speedRateText.text =  CurrentSpeedRate.ToString() + "x";
    }

    public void DoStopSpeed()
    {
        if(paused)
        {
            Time.timeScale = previouslSpeedRate;
            paused = false;
        }
        else
        {
            Time.timeScale = 0;
            paused = true;
        }
    }
}
