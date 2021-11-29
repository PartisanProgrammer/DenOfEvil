using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FD_CameraFollow : MonoBehaviour
{

[SerializeField] Transform target;
[SerializeField] Vector3 offset;
[SerializeField] float smoothTime = 0.3f;

Vector3 _velocity = Vector3.zero;



    // Start is called before the first frame update
    void Start(){
        target = FindObjectOfType<FD_PlayerMovement>().transform;
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate(){
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, smoothTime);
    }
}
