using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeINcrease : MonoBehaviour
{

    public Timer timer;

    [SerializeField] float amountTimeIncrease = 10f;

    void OnTriggerEnter(Collider other)
    {
        float currentTime = timer.GetTime();
        Debug.Log("current time limit: " + currentTime);

        timer.SetTime(currentTime + amountTimeIncrease);
        Debug.Log("new time limit: " + timer.GetTime());
    }
}
