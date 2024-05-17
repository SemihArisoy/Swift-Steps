using SwiftSteps.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SwiftSteps.Movements
{
    public class HorizontalMover
    {
        PlayerController _playerController;

        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void TickFixed(float horizontal, float moveSpeed)
        {
            if (horizontal == 0) return;

            _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * moveSpeed);
        }
    }
}

