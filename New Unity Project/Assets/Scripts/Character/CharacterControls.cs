using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControls : MonoBehaviour
{
    private Vector3 position;
    private CharacterController _controller;
    private Vector3 rotation;

    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    public float rotateSpeed = 2;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        position.Set(0,-gravity, Input.GetAxis("Vertical")*moveSpeed);
        rotation.Set(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(rotation);
        position.y -= gravity;
        position = transform.TransformDirection(position * moveSpeed * Time.deltaTime);

        if (Input.GetButton("Jump"))
        {
            position.y = jumpSpeed;
        }
        _controller.Move(position * Time.deltaTime);
    }
}