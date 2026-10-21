using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptToJump : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed){
            rb.AddForce(transform.up*20f);
        }
    }
}
