using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attack : MonoBehaviour
{

    [Header("Refrences")]
    [SerializeField] Transform character;
    [SerializeField] Transform attackPoint;
    [SerializeField] GameObject objectToThrow;
    Vector3 targetLocation;


    [Header("Settings")]
    public int totalThrows;
    public float cooldown;

    [Header("Throwing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce;
    


    bool readyToThrow;

    private void Start()
    {
        readyToThrow = true;
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

       // Raycast target Location
        if (Physics.Raycast(ray, out hit, 100f))
        {
            targetLocation = hit.point;

        }

     
        Vector3 targetDirection = targetLocation - transform.position;
        targetDirection.y = 0;

        transform.LookAt(transform.position + targetDirection, Vector3.up);

       //Shootinng
        if (Input.GetKeyDown(throwKey)&& readyToThrow && totalThrows > 0)
        {
            readyToThrow = false;
            //instantiate Object
            GameObject granade = Instantiate(objectToThrow, attackPoint.position, transform.rotation);

            //get riggidbody
            Rigidbody projectileRb = granade.GetComponent<Rigidbody>();

          
            projectileRb.AddForce(targetDirection, ForceMode.Impulse);

            totalThrows--;




            Invoke(nameof(ResetThrow), cooldown);

        }


    }


    private void ResetThrow()
    {
        readyToThrow=true;
    
    }


   


}
