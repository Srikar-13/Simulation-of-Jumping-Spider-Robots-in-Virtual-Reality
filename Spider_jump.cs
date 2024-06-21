using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider_jump : MonoBehaviour {

    public float jumpForce = 10f;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other) {
        // Check if the collider belongs to the stone object
        if (other.gameObject.CompareTag("Stone")) {
            Debug.Log("Collision");
            // Calculate jump direction
            Vector3 jumpDirection = Vector3.up * jumpForce;
            Debug.DrawRay(transform.position, jumpDirection, Color.green);

            // Add the jump force to the spider's Rigidbody component
            rb.AddForce(jumpDirection, ForceMode.Impulse);

            // Play jump animation
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("Jump");
        }
    }
}