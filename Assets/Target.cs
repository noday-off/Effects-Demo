using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private ParticleSystem particle;
    private void Start()
    {
        particle = GetComponentInChildren<ParticleSystem>();
    }
    private void Update()
    {
        if (particle.isPaused)
        {

        }
    }
}
