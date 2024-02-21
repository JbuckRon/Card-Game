using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Only one instance can exist of this in each scene
/// </summary>

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

    }


}
