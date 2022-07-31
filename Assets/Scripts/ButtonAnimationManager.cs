using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationManager : MonoBehaviour
{
    public Animator buttonAnimator;
    public Animator lightRaysAnimator;
    public Animator surpriseBoxTextAnimator;
    public Animator [] newToppingTextAnimator;
    public Animator bottleAnimator;
    public Animator boxAnimator;

    private float boxAnimationEndTime;

    public void PlayAnimationsOnClick ()
    {
        StartCoroutine ( PlayAnimations () );
    }

    public IEnumerator PlayAnimations ()
    {

        PlayButtonScaleDownAnimation ();
        PlayBoxAnimation ();

        yield return new WaitForSeconds ( 2.0f );

        PlayLightRaysAnimation ();
        PlayBottleAnimation ();

        yield return new WaitForSeconds ( 0.8f );

        PlayTextAnimations ();

        yield return new WaitForSeconds ( 2.0f );

        PlayButtonScaleUpAnimation ();
    }

    private void PlayButtonScaleDownAnimation ()
    {
        buttonAnimator.SetBool ( "ScaleButtonDown", true );
        buttonAnimator.SetBool ( "ScaleButtonUp", false );
    }

    private void PlayButtonScaleUpAnimation ()
    {
        buttonAnimator.SetBool ( "ScaleButtonDown", false );
        buttonAnimator.SetBool ( "ScaleButtonUp", true );
    }

    private void PlayLightRaysAnimation ()
    {
        lightRaysAnimator.SetBool ( "StartRotate", true );
        lightRaysAnimator.SetBool ( "StopRotatin", false );
    }

    private void PlayTextAnimations ()
    {
        surpriseBoxTextAnimator.SetBool ( "ScaleTextDown", true );
        newToppingTextAnimator [ 0 ].SetBool ( "ScaleTextUp", true );
        newToppingTextAnimator [ 1 ].SetBool ( "ScaleTextUp", true );
    }

    private void PlayBottleAnimation ()
    {
        bottleAnimator.SetBool ( "PlayAnimations", true );
    }

    private void PlayBoxAnimation ()
    {
        boxAnimator.SetBool ( "OpenBox", true );
    }
}
