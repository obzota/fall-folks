using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadController : MonoBehaviour
{

    public Button submitButton;
    public Logger logger;
    public Button[] buttons;
    public Text textField;
    private string text_ = "";

    public bool submitted = true;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++) 
        {
            int index = i;
            buttons[i].onClick.AddListener(() => {
                if(submitted) {
                    submitted = false;
                    text_ = "";
                }
                text_ += string.Format("{0}", index);
                textField.text = text_;
            });
        }

        submitButton.onClick.AddListener(() => {
            submitted = true;
            textField.text = "P" + text_;
            logger.Log("Participant: P" + text_);
        });
    }
}
