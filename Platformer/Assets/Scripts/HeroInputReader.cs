using UnityEngine;
using UnityEngine.InputSystem;

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
}
