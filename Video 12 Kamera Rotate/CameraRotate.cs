using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private float mouseX;
    [SerializeField] private float mouseY;

    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X"); // sag sol tutuyoruz
        mouseY = Input.GetAxis("Mouse Y");

        transform.eulerAngles += new Vector3(0, mouseX, 0);

        transform.eulerAngles -= new Vector3(mouseY, 0, 0);
    }
}
