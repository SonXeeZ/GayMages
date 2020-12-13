using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKovetes : MonoBehaviour
{
    public Transform target;

    public float sebesseg = 0.125f;

    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 celPozicio = target.position + offset;
        Vector3 smoothedPozicio = Vector3.Lerp(transform.position,celPozicio,sebesseg);
        transform.position = smoothedPozicio;
    }
}
