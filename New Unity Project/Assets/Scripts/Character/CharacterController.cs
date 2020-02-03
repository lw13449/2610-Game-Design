using UnityEngine;

[RequireComponent(typeof(CharacterController))
public class CharacterController : MonoBehaviour
{
    private Vector3 position;
    private CharacterController _controller;

    public float moveSpeed = 10f; gravity = 9.81f, jumpSpeed = 30f;

    public float rotateSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(Input.GetAxis("Vertical"));
        Rotate(Input.GetAxis("Horizontal"));
    }
    public void Move (float myInput)
    {
        position.x = myInput;
        position = transform.TransformDirection(position * moveSpeed * Time.deltaTime);
    }

    void Rotate(float myInput)
    {
        transform.Rotate(0, myInput * rotateSpeed, 0);
    }
}
