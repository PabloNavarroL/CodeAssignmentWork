using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBridge : MonoBehaviour
{
    [SerializeField] GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        door.transform.position += new Vector3(0, -2, 0);
    }
}
