using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyboardInteraction : OVRVirtualKeyboard.AbstractTextHandler
{
    public override Action<string> OnTextChanged { get; set; }

    public override string Text { get; }
    public override bool SubmitOnEnter { get => SubmitOnEnter; }
    public override bool IsFocused => true;

    public Logger logger;

    private string text_ = "";

    public override void Submit() {
        logger.Log(this.text_);
        this.text_ = "";
    }
    public override void AppendText(string s) {
        this.text_ += s;
    }

    public override void ApplyBackspace() {
        if(string.IsNullOrEmpty(this.text_)) {
            return;
        }
        this.text_ = this.text_.Substring(0, this.text_.Length - 1);
    }

    public override void MoveTextEnd() {
    }
    
}
