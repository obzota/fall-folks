using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScalingCanvas : MonoBehaviour
{
    public ScaledMovement scaledMovementScript; // Reference to the ScaledMovement script

    // public Button scaleOne;
    // public Button scaleThree;
    // public Button scaleFive;

    public OVRInput.Button reset;
    public OVRInput.Button lowScaling;
    public OVRInput.Button highScaling;

    public Transform spawnPoint;
    public Transform vrRig;

    void Start()
    {
        if (scaledMovementScript == null)
        {
            Debug.LogError("ScaledMovement script reference not assigned.");
            return;
        }

        // Add listeners to buttons
        // scaleOne.onClick.AddListener(setScaleToOne);
        // scaleThree.onClick.AddListener(setScaleToThree);
        // scaleFive.onClick.AddListener(setScaleToFive);
    }

    void Update() {
        // if(OVRInput.GetDown(reset)){
        //     vrRig.position = spawnPoint.position;
        //     scaledMovementScript.previousPosition = spawnPoint.position;
        // }

        if (OVRInput.GetDown(lowScaling)){
            Debug.Log("Low scaling");
            scaledMovementScript.scaleFactor = 3.0f;
        }

        if(OVRInput.GetDown(highScaling)){
            Debug.Log("High scaling");
            scaledMovementScript.scaleFactor = 5.0f;
        }
        
    }

    void setScaleToOne()
    {
        scaledMovementScript.scaleFactor = 1.0f;
        Debug.Log("Scale Factor set to: " + scaledMovementScript.scaleFactor);
    }

    void setScaleToThree()
    {
        scaledMovementScript.scaleFactor = 3.0f;
        Debug.Log("Scale Factor set to: " + scaledMovementScript.scaleFactor);
    }

    void setScaleToFive()
    {
        scaledMovementScript.scaleFactor = 5.0f;
        Debug.Log("Scale Factor set to: " + scaledMovementScript.scaleFactor);
    }

}
