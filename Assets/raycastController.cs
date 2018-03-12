using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastController : MonoBehaviour
{
	void Update ()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward,Color.green);
	}
}
