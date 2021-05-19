using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public float speed = 1.2f;
    public Transform target;

    private float x;
    private float y;
    private float z;
    private float distance = 2.0f;

    float velocityX = 0.0f;
    float velocityY = 0.0f;

    // Start is called before the first frame update
    void Start() {
        if (GetComponent<Rigidbody>()) {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(1)) {
            velocityX += 20.0f * Input.GetAxis("Mouse X") * 0.50f;
            velocityY -= 20.0f * Input.GetAxis("Mouse Y") * 0.50f;
        }
        Quaternion rotation = Quaternion.Euler(velocityY, velocityX, 0);
        distance = Mathf.Clamp(distance - Input.GetAxis("Mouse ScrollWheel") * 5, 10f, 10f);
        Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);

        transform.rotation = rotation;
        transform.position = rotation * negDistance + target.position;
    }

    void OnGUI() {
        GUIStyle style = new GUIStyle();
        style.fontSize = 24;

        GUI.Label(new Rect(10, 0, 0, 0), "Debug: " + target, style);
    }

    public static float ClampAngle(float angle, float min, float max) {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
     }
}