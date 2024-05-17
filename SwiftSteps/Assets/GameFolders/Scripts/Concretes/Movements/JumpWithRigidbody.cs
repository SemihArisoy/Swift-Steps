using SwiftSteps.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SwiftSteps.Movements
{
    public class JumpWithRigidbody
    {
        private Rigidbody _rigidBody;

        public JumpWithRigidbody(PlayerController playerController)
        {
            _rigidBody = playerController.GetComponent<Rigidbody>();
        }

        public void TickFixed(float jumpForce)
        {
            if (_rigidBody.velocity.y != 0) return;

            Debug.Log(_rigidBody.velocity.y);

            _rigidBody.velocity = Vector3.zero;
            _rigidBody.AddForce(Vector3.up * Time.deltaTime * jumpForce);
        }
    }
}

