using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksFire : MonoBehaviour
{
    [SerializeField] ParticleSystem _fireworks;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _fireworks.Emit(1);
        }
    }
}
