using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    [SerializeField] private float mouseX;
    [SerializeField] private float mouseY;

    [SerializeField] private float minLimit;
    [SerializeField] private float maxLimit;

    private Vector3 targetVector;
    private Vector3 zero = Vector3.zero;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        targetVector = transform.eulerAngles;

        mouseX = Input.GetAxis("Mouse X"); // sag sol tutuyoruz
        mouseY = Input.GetAxis("Mouse Y");

        targetVector += new Vector3(0, mouseX * rotationSpeed * Time.deltaTime, 0);

        targetVector -= new Vector3(mouseY * rotationSpeed * Time.deltaTime, 0, 0);

        float startValue = targetVector.x;

        if (180 < startValue && startValue < minLimit)
            targetVector = new Vector3(minLimit, targetVector.y, targetVector.z);

        if (maxLimit < startValue && startValue < 180)
            targetVector = new Vector3(maxLimit, targetVector.y, targetVector.z);

        if (Input.GetMouseButtonDown(1))
            targetVector = Vector3.zero;

        transform.eulerAngles = targetVector;

    }
}
