using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 0f;
        }
        if(Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 2f;
        }
    }

    private void OnParticleSystemStopped()
    {
        Debug.Log("파티클 동작 종료");
    }
}
