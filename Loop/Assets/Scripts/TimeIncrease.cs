using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class TimeIncrease : MonoBehaviour
{

    public Timer timer;

    [SerializeField] float amountTimeIncrease = 10f; // I'm guessing this is in seconds?

    void OnTriggerEnter(Collider other)
    {

        float currentTimeLimit = timer.GetTime();
        Debug.Log("Current Time: " + currentTimeLimit);

        // increment current time limit by time limit amount
        timer.SetTime(currentTimeLimit + amountTimeIncrease);
        Debug.Log("New Time: " + timer.GetTime());

    }

}
