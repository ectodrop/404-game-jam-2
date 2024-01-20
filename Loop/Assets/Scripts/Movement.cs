using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
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
            z += speed * Time.deltaTime;
        }

        // Left
        if (Input.GetKey(KeyCode.A))
        {
            x -= speed * Time.deltaTime;
        }

        // Backward
        if (Input.GetKey(KeyCode.S))
        {
            z -= speed * Time.deltaTime;
        }

        // Right
        if (Input.GetKey(KeyCode.D))
        {
            x += speed * Time.deltaTime;
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

        player.transform.position = new Vector3(x, y, z);
    }
}
