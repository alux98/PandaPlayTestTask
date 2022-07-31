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
        StartCoroutine ( ChangeText () );
    }

    public IEnumerator ChangeText ()
    {
        if ( buttonText.text == "GET" )
        {
            SceneManager.LoadScene ( "MainScene" );
        }
        else
        {
            yield return new WaitForSeconds ( 2.0f );
            buttonText.text = "GET";
        }
    }
}
