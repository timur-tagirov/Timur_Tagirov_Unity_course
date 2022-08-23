﻿using UnityEngine;
using UnityEngine.InputSystem;

namespace PixelCrew.Components
{

    public class HeroInputReader : MonoBehaviour
    {
        [SerializeField] private Hero _hero;

        public void OnMovement(InputAction.CallbackContext context)
        {
            var Movement = context.ReadValue<Vector2>();
            _hero.SetDirection(Movement);
        }

        public void OnSaySomething(InputAction.CallbackContext context)
        {
            if (context.canceled)
            {
                _hero.SaySomething();
            }

        }

        public void OnInteract(InputAction.CallbackContext context)
        {
            if (context.canceled)
            {
                _hero.Interact();
            }
        }
    }
}
