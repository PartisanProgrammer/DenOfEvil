using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FD_CameraFollow : MonoBehaviour
{

[SerializeField] Transform target;
[SerializeField] Vector3 offset = new Vector3(0,10,0);




    // Start is called before the first frame update
    void Start(){
        target = FindObjectOfType<FD_PlayerMovement>().transform;
        
    }

    // Update is called once per frame
    void Update(){
        transform.position = target.position + offset;
    }
}
