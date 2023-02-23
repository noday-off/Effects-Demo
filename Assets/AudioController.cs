using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;
    void Update()
    {
        if (!gameObject.transform.parent.GetComponent<CircleCollider2D>().enabled)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
