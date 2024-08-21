using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaledMovement : MonoBehaviour
{
    public Transform player;
    public Transform headPosition;
    public float scaleFactor = 3.0f;
    public Vector3 previousPosition;
    public bool allDimensions = true;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            Debug.LogError("VR Rig not assigned.");
            return;
        }
        // Initialize the previous position
        previousPosition = headPosition.position;
        // Debug.Log("Initial Position: " + previousPosition);
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the difference in position
        Vector3 deltaPosition = headPosition.position - previousPosition;
        // Debug.Log("Delta Position: " + deltaPosition);

        // remove one because the head already moved for 1 length
        Vector3 scaledDeltaPosition = deltaPosition * (scaleFactor - 1);

        // Apply the scaled movement to the parent object
        if(allDimensions) {
            player.position += scaledDeltaPosition;
        } else {
            player.position += new Vector3(0, scaledDeltaPosition.y, 0);
        }

        // Update the previous position
        previousPosition = headPosition.position;

    }
}
