using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraOrientationScript : MonoBehaviour {

    public Image compassImage;

    private bool isGyroEnabled;
    private Gyroscope gyroscope;

    private GameObject cameraContainer;
    private Quaternion rot;

    private void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;

        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);

        isGyroEnabled = enableGyro();
    }

    private bool enableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyroscope = Input.gyro;
            gyroscope.enabled = true;

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 180f, 0);
            rot = new Quaternion(0, 0, 1, 0);
            return true;
        }
        else
        {
            return false;
        }

    }

    private void Update()
    {
        compassImage.transform.localRotation = Quaternion.Euler(0, 0, Input.compass.trueHeading);

        if (isGyroEnabled)
        {
            transform.localRotation = gyroscope.attitude * rot;
        }
    }
}
