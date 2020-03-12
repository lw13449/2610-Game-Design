using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class CharacterControls : MonoBehaviour
{
    private Vector3 position;
    private CharacterController _controller;
    private Vector3 rotation;

    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 80f;
    public float rotateSpeed = 2;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (_controller.isGrounded)
        {
            position = new Vector3(0, 0, Input.GetAxis("Vertical")*moveSpeed);
            rotation.y = Input.GetAxis("Horizontal") * rotateSpeed;
            transform.Rotate(rotation);
            position = transform.TransformDirection(position * moveSpeed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump"))
        {
            position.y += jumpSpeed;
        }
        position.y -= gravity;
        _controller.Move(position * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.K))
        {
            //This is where you either set the switch to true to deactivate gates
            //also plug into Motherboard when in trigger area, and boot health to full
        }

        if (position.y <= -400)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}