using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    // How to make a C# ----> Accesor datatype varName
    public CharacterController controller; // A var to hold the players char controller component
   
    public float moveSpeed = 5;
    
    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        // calculate direction the player should based on our collected input
        Vector3 movement = new Vector3(HorizontalInput, 0, VerticalInput);
        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}