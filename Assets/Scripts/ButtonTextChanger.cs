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
        if ( buttonText.text == "OPEN" )
        {
            buttonText.text = "GET";
        }
        else if ( buttonText.text == "GET" )
        {
            buttonText.text = "OPEN";
        }
    }
}
