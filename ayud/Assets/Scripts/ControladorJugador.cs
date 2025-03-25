using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(MovimientoX))]

public class ControladorJugador : MonoBehaviour
{
    // Movimiento en X
    private MovimientoX movimientoX { get; set; }

    void Start()
    {
        // Obtener el componente MovimientoX
        movimientoX = GetComponent<MovimientoX>();
    }

    void Update()
    {
        movimientoX.Mover();
    }

    public void MoverEjeX(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            movimientoX.Acelerar();
        }
        else if (context.performed)
        {
            Vector2 direccion = context.ReadValue<Vector2>();
            movimientoX.CambiarDireccion(direccion.x);
        }
        else if (context.canceled)
        {
            movimientoX.Desacelerar();
            movimientoX.CambiarDireccion(0f);
        }
    }
}