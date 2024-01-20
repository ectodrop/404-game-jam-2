using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public GameObject cameraObj;
    public Vector3 startPos;
    public float defaultSpeed;

    private float x; // Left/Right
    private float y; // Up/Down
    private float z; // Forward/Backward
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = defaultSpeed;
        x = startPos.x;
        y = startPos.y;
        z = startPos.z;
    }

    // Update is called once per frame
    void Update()
    {
        // Forward
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += cameraObj.transform.forward * speed * Time.deltaTime;
        }

        // Left
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= cameraObj.transform.right * speed * Time.deltaTime;
        }

        // Backward
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position -= cameraObj.transform.forward * speed * Time.deltaTime;
        }

        // Right
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += cameraObj.transform.right * speed * Time.deltaTime;
        }

        // Sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = defaultSpeed * 2;
        }
        else
        {
            speed = defaultSpeed;
        }
    }
}
