using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMenu : MonoBehaviour
{
    public GameObject canvas; // Reference to the Canvas GameObject
    public OVRInput.Button toggleButton = OVRInput.Button.One; // Default button (A button on Oculus Touch Controller)

    private bool isCanvasActive = false; // Track the canvas state

    void Update()
    {
        // Check if the toggle button is pressed
        if (OVRInput.GetDown(toggleButton))
        {
            // Toggle the canvas's active state
            isCanvasActive = !isCanvasActive;
            canvas.SetActive(isCanvasActive);
        }
    }
}
