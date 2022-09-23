using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class CameraController : MonoBehaviour
{
    Rigidbody rigidBod;


    [SerializeField] private float movementSpeed = 5f;
    //CameraRotation
    [SerializeField] private float rotationSpeed = 5f;

    private void Start()
    {
        rigidBod = GetComponent<Rigidbody>();
    }

    void Update()
    {
       

        
        CameraStrafe(); 
  
    }




    void CameraStrafe()
    {


        if (Input.GetKey(KeyCode.W))
        {
      
            rigidBod.velocity = transform.forward * movementSpeed;
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            
            rigidBod.velocity = -transform.forward * movementSpeed;
            
        }
        if (Input.GetKey(KeyCode.D))
        {

            rigidBod.velocity = transform.right * movementSpeed;

        }
        if (Input.GetKey(KeyCode.A))
        {

            rigidBod.velocity = -transform.right * movementSpeed;

        }



        //Rotation

        if (Input.GetKey(KeyCode.E))
        {
            
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * rotationSpeed, Space.World);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * rotationSpeed, Space.World);
        }




    }





}
