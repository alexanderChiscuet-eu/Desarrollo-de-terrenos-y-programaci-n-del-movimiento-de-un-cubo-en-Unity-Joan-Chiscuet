using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class MovimientoCubo : MonoBehaviour
{
    public float velocidad = 5f;
    public Transform camara;
    public Vector3 desplazamientoCamara = new Vector3(0f, 18f, -24f);

    private CharacterController controlador;
    private float velocidadVertical;

    private void Awake()
    {
        controlador = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Keyboard teclado = Keyboard.current;
        if (teclado == null)
            return;

        float horizontal = 0f;
        float vertical = 0f;

        if (teclado.dKey.isPressed || teclado.rightArrowKey.isPressed)
            horizontal += 1f;
        if (teclado.aKey.isPressed || teclado.leftArrowKey.isPressed)
            horizontal -= 1f;
        if (teclado.wKey.isPressed || teclado.upArrowKey.isPressed)
            vertical += 1f;
        if (teclado.sKey.isPressed || teclado.downArrowKey.isPressed)
            vertical -= 1f;

        if (controlador.isGrounded && velocidadVertical < 0f)
            velocidadVertical = -2f;

        velocidadVertical += Physics.gravity.y * Time.deltaTime;

        // Limita la velocidad cuando se avanza en diagonal.
        Vector3 direccion = Vector3.ClampMagnitude(
            new Vector3(horizontal, 0f, vertical), 1f);
        Vector3 movimiento = direccion * velocidad;
        movimiento.y = velocidadVertical;
        controlador.Move(movimiento * Time.deltaTime);

        MantenerEnTerreno();

        if (teclado.rKey.wasPressedThisFrame)
            ReiniciarPosicion();
    }

    private void MantenerEnTerreno()
    {
        Vector3 posicion = transform.position;
        posicion.x = Mathf.Clamp(posicion.x, -28f, 28f);
        posicion.z = Mathf.Clamp(posicion.z, -28f, 28f);

        if (posicion.y < -5f)
            ReiniciarPosicion();
        else if (transform.position != posicion)
            ColocarEn(posicion);
    }

    private void ReiniciarPosicion()
    {
        ColocarEn(new Vector3(0f, 5f, -18f));
        velocidadVertical = 0f;
    }

    private void ColocarEn(Vector3 posicion)
    {
        controlador.enabled = false;
        transform.position = posicion;
        controlador.enabled = true;
    }

    private void LateUpdate()
    {
        if (camara == null)
            return;

        camara.position = transform.position + desplazamientoCamara;
        camara.LookAt(transform.position + Vector3.forward * 6f);
    }
}
