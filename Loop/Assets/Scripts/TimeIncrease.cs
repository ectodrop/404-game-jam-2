using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TimeINcrease : MonoBehaviour
{

    [SerializeField] public TimeController timer;
    public AudioSource collectSound;
    [SerializeField] float amountTimeIncrease = 10f;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collectSound.Play();
            Destroy(gameObject);
            float currentTime = timer.GetTime();
            Debug.Log("current time limit: " + currentTime);

            timer.SetTime(currentTime + amountTimeIncrease);
            Debug.Log("new time limit: " + timer.GetTime());
        }
    }
}
