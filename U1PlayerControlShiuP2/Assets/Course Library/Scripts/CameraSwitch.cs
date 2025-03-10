using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour


{

    public Camera camera1; // first camera
    public Camera camera2; // second camera

    // key to switch cameras
    public KeyCode switchKey = KeyCode.Space;
    // Start is called before the first frame update
    void Start()
    {
        // make sure the first camera is active and the second is inactive at the start
        if (camera1 != null && camera2 != null)
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            SwitchCameras();
        }
    }
    void SwitchCameras()
    {
        // Toggle between the two cameras
        if (camera1.enabled)
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
        else
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }
    }
}