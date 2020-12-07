using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public Camera FirstPersonCam;
    public Camera ThirdPersonCam;
    bool firstpersonCam = true;

    // Start is called before the first frame update
    void Start()
    {
        FirstPersonCam.enabled = firstpersonCam;
        ThirdPersonCam.enabled = !firstpersonCam;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            firstpersonCam = !firstpersonCam;
            FirstPersonCam.enabled = firstpersonCam;
            ThirdPersonCam.enabled = !firstpersonCam;
        }
    }
}
