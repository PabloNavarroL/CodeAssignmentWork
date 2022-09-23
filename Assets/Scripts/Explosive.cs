using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    [Header("Other Script Access")]
    PlayerBehaviour playerBehaviour;
    [SerializeField] GameObject player;

    [Header("ExplotionForce")]
    [SerializeField] private float delay = 5f;
    [SerializeField] private float radious = 5f;
    [SerializeField] private float force = 50f;

    [Header("ExplotionSettings")]
    [SerializeField] private GameObject explosionEffect;
    private float countdown;
    private bool hasExploded = false;
    [SerializeField] GameObject dmgSphere;
    



    private void Awake()
    {
        playerBehaviour = player.GetComponent<PlayerBehaviour>();
    }


    void Start()
    {
        countdown = delay;
    }

  
    void Update()
    {
        countdown-= Time.deltaTime;
        if (countdown <= 0f && !hasExploded )
        {
            Explode();
            hasExploded = true;
        }
    }


    void Explode()
    {
        
        Instantiate(explosionEffect, transform.position, transform.rotation);
        

        Collider[] colliders = Physics.OverlapSphere(transform.position, radious);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radious);
                

            }
        }

        Destroy(gameObject);
        
    }


   void OnCollisionEnter(Collider player)
    {
        
    }


}
