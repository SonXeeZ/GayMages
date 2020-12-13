using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_trap : MonoBehaviour
{
    private float time = 0.0f;
    public float interpolationPeriod = 1f;

    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = time - interpolationPeriod;

            
        }
    }
}
