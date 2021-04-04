using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    public float speed = 1.2f;

    private float x;
    private float y;
    private float z;

    // Update is called once per frame
    void Update() {
        Movement();

        transform.position += (new Vector3(x, y, z) * (Time.deltaTime * speed));
        z = y = x = 0;
    }

    private void Movement() {
        if (Input.GetKey("w")) z = 2;
        if (Input.GetKey("s")) z = -2;
        if (Input.GetKey("a")) x = -2;
        if (Input.GetKey("d")) x = 2;
        if (Input.GetKey("y")) y = 2;
    }
}
