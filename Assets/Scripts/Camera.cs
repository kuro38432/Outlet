using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Camera mainCamera;
    private Vector3 velocity = Vector3.zero;

    // Moves the camera
    void FixedUpdate()
    {
        mainCamera.transform.localPosition = Vector3.SmoothDamp(mainCamera.transform.localPosition, new Vector3(gameObject.transform.position.x, 0.0f, -10.0f), ref velocity, 0.2f);
    }
}

