using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player; // LookAt kullanacagiz
    [SerializeField] private Transform followPoint; // Kamera surekli bu noktayi takip edecek


    private void LateUpdate()
    {
        transform.position = followPoint.position;
        transform.LookAt(player);
    }
}
