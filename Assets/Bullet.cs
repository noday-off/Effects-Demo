using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        var target = collision.gameObject;
        ParticleSystem target_particle = target.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>();
        target.GetComponent<SpriteRenderer>().enabled = false;
        target.GetComponent<CircleCollider2D>().enabled = false;
        target_particle.Play();
        Destroy(target, target_particle.main.duration);
    }
}
