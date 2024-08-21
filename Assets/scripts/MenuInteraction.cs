using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInteraction : MonoBehaviour
{

    public Logger logger;

    // public Button xButton;
    // public Button yButton;
    // public Button zButton;

    public Toggle xToggle;
    public Toggle yToggle;
    public Toggle zToggle;
    public Button showKeyboardButton;

    // public OVRVirtualKeyboard keyboard;

    // private bool isKeyboardActive = false;

    public ScaledMovement scaledMovement;

    // Start is called before the first frame update
    void Start()
    {
        // if(xButton)
        // {
        //     xButton.onClick.AddListener(onX);
        // }
        // if(yButton)
        // {
        //     yButton.onClick.AddListener(onY);
        // }
        // if(zButton)
        // {
        //     zButton.onClick.AddListener(onZ);
        // }

        if(xToggle)
        {
            xToggle.onValueChanged.AddListener(onX);
        }
        if(yToggle)
        {
            yToggle.onValueChanged.AddListener(onY);
        }
        if(zToggle)
        {
            zToggle.onValueChanged.AddListener(onZ);
        }

        // if(showKeyboardButton)
        // {
        //     showKeyboardButton.onClick.AddListener(onShowKeyboard);
        // }
        // isKeyboardActive = false;
    }

    // public void onZ() {
    //     scaledMovement.scaleFactor = 5.0f;
    //     logger.Log("Scale Factor: 5");
    // }


    // public void onX() {
    //     // xButton.selected = true;
    //     // zButton.selected = false;
    //     // yButton.selected = false;
    //     scaledMovement.scaleFactor = 1.0f;
    //     logger.Log("Scale Factor: 1");
    // }


    // public void onY() {
    //     // yButton.selected = true;
    //     // zButton.selected = false;
    //     // xButton.selected = false;
    //     scaledMovement.scaleFactor = 3.0f;
    //     logger.Log("Scale Factor: 3");
    // }

    public void onX(bool toggleValue)
    {
        if (toggleValue) {
            scaledMovement.scaleFactor = 1.0f;
            logger.Log("Scale Factor: 1");
        }
    }
    public void onY(bool toggleValue)
    {
        if (toggleValue) {
            scaledMovement.scaleFactor = 3.0f;
            logger.Log("Scale Factor: 3");
        }
    }
    public void onZ(bool toggleValue)
    {
        if (toggleValue) {
            scaledMovement.scaleFactor = 5.0f;
            logger.Log("Scale Factor: 5");
        }
    }

    // void onShowKeyboard() {
    //     if(!this.keyboard) {
    //         return;
    //     }
    //     if (this.isKeyboardActive) {
    //         keyboard.gameObject.SetActive(false);
    //         isKeyboardActive = false;
    //     } else {
    //         keyboard.gameObject.SetActive(true);
    //         isKeyboardActive = true;
    //     }
    // }
}
