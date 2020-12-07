using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    public int pointsTotal = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        // Character controller movement
        var characterController = this.GetComponent<CharacterController>();
        characterController.SimpleMove(new Vector3(
            Input.GetAxis("Horizontal") * this.speed,
            0.0f,
            Input.GetAxis("Vertical") * this.speed
            ));

    }
}
