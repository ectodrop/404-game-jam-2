using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour, Timer
{
    public TextMeshProUGUI timerText;
    public float time = 30.0f;
    public AudioSource endTimeSound;
    private bool resetting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resetting)
        {
            return;
        }
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = 0f;
            resetting = true;
            endTimeSound.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        var timeString = time.ToString("N2").Split(".");

        timerText.SetText($"{timeString[0]}:{timeString[1]}");
    }

    public void SetTime(float newTime)
    {
        time = newTime;
    }

    public float GetTime()
    {
        return time;
    }
}
