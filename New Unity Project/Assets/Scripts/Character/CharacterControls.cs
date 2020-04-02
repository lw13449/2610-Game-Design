using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class CharacterControls : MonoBehaviour
{
    private Vector3 position = Vector3.zero;
    private CharacterController controller;
    
    public float moveSpeed = 100f,  gravity = 9.81f, jumpSpeed = 60f;
    private int jumpCount;
    public int jumpCountMax = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        position.x = Input.GetAxis("Horizontal") * moveSpeed;
        position.z = Input.GetAxis("Vertical") * moveSpeed;
        if (position.x != 0)
        {
            if (position.z != 0)
            {
                transform.forward = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            }
        }
        position.y -= gravity;

        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        
        controller.Move(position*Time.deltaTime);
        
        if (position.y <= -1000)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
