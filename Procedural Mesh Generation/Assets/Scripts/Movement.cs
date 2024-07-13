using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    CharacterController controller;
    public float movementSpeed = 10f;
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        controller.Move(moveInput * Time.deltaTime * movementSpeed);
    }
}
