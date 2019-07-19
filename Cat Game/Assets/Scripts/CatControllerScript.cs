using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatControllerScript : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + 8f * horizontal* Time.deltaTime;
        transform.position = position;

        if (horizontal > 0) { GetComponent<SpriteRenderer>().flipX = true; }

        else if (horizontal < 0) { GetComponent<SpriteRenderer>().flipX = false; }

    }
}

