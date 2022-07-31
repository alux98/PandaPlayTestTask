using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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

        /*if ( buttonText.text == "GET" )
        {
            SceneManager.LoadScene ( "MainScene" );
        }*/
    }
}
