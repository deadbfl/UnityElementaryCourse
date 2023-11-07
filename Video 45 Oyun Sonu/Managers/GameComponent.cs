using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComponent : MonoBehaviour
{
    public static GameComponent instance;

    public Transform player;
    private void Awake()
    {
        instance = this;
    }
}
