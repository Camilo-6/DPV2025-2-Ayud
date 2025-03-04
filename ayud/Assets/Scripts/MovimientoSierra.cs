using UnityEngine;

public class MovimientoCierra : MonoBehaviour
{
    // Objeto prefab "chain"
    [SerializeField] private GameObject chain;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Mover el objeto de izquierda a derecha (de x = -1 a x = 1) en un tiempo de 4 segundos
        transform.position = new Vector3(Mathf.PingPong(Time.time / 4, 2) - 1, transform.position.y, transform.position.z);
        // Al moverse, crear un objeto prefab "chain" si no hay uno en la posicion nueva, solo crear cada 1 segundo
        if (Time.time % 1 < Time.deltaTime)
        {
            if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y - 0.5f), 0.1f))
            {
                Instantiate(chain, new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), Quaternion.identity);
                Debug.Log("Chain created");
            }
        }
    }
}
