using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public float sensitvity;

    // Update is called once per frame
    void Update() {
        Movement();
    }

    private void Movement() {
        if (Input.GetKey("w")) {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        }
        if (Input.GetKey("s")) {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime);
        }
        if (Input.GetKey("a")) {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey("d")) {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        }
    }
}
