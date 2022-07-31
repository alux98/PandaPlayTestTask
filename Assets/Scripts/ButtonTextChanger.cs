using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTextChanger : MonoBehaviour
{
    public TMP_Text buttonText;


    public void ChangeTextWithDelay ()
    {
        Invoke ( "ChangeText", 2 );
    }

    public void ChangeText ()
    {
        buttonText.text = "GET";
    }
}
