using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform R_index_c;// Reference to the object to follow
    public float moveSpeed = 3f; 
    public Transform R_thumb_b;
    
    void Update()
    {
        // Check if the rightObject reference is not null
        if (R_index_c != null)
        {
        /* wasd
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        */
        // Calculate the direction towards the rightObject
        // Vector3 moveDirection = (Hand_High_Arm.position - transform.position).normalized;

        // Move the object in the calculated direction
        // transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        Debug.Log(R_index_c.position);
        Vector3 newPosition = new Vector3(R_index_c.position.x, transform.position.y, R_index_c.position.z);
        transform.position = newPosition;

        Vector3 newRotation = new Vector3(transform.rotation.eulerAngles.x, R_thumb_b.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        Quaternion newRotationQuaternion = Quaternion.Euler(newRotation);
        transform.rotation = newRotationQuaternion;

        //transform.position = R_index_c.position;
        }
    }
}
