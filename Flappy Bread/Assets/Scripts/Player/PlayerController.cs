using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _heightVelocity;
    private InputSystem_Actions _input;
    private Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _input = new InputSystem_Actions();

        _input.Player.Jump.performed += OnJump;
    }

    private void OnEnable()
    {
        _input.Player.Enable();        
    }

    private void OnDisable()
    {
        _input.Player.Disable();       
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        _rb.AddForce(new Vector2(0, _heightVelocity), ForceMode2D.Impulse);
    }
}
