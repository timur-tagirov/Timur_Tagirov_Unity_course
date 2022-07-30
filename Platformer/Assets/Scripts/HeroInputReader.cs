using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{

    [SerializeField] private Hero _hero;


    public void OnHorizontalMovement(InputAction.CallbackContext context)
    {
        var horizontalDirection = context.ReadValue<float>();
        _hero.SetHorizontalDirection(horizontalDirection);

    }

    public void OnVerticalMovement(InputAction.CallbackContext context)
    {
        var verticalDirection = context.ReadValue<float>();
        _hero.SetVerticalDirection(verticalDirection);

    }


    public void OnSaySomething(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            _hero.SaySomething();
        }

    }

}
