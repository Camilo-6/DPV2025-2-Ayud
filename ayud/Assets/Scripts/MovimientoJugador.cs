using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    // Vida
    public Vida vida;

    // Update is called once per frame
    void Update()
    {
        // Al tocar la tecla izquierda permedomos vida
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            vida.PerderVida(10);
            Debug.Log("Vida: " + vida.vidaActual);
        }
    }

}