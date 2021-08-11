using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 20.0f;
    private PlayerController playerControllerScript;
    private float leftBound;
    public float diffIncreaseTime;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        diffIncreaseTime = Time.time + 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < -10 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        if (Time.time > diffIncreaseTime)
        {
            speed += 3.0f;
            diffIncreaseTime += 3.0f;
        }
    }
}
