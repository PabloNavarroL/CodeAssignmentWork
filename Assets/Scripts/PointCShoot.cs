using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointCShoot : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public GameObject projectile;
    public Animator playerAnimator;
    public GameObject targetDestination;
  

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if (Physics.Raycast(ray, out hitPoint))
            {
                targetDestination.transform.position = hitPoint.point;
                
            }
        }


    }
}
