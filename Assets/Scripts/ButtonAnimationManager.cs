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
        
        yield return new WaitForSeconds ( boxAnimator.GetCurrentAnimatorClipInfo ( 0 ).Length );
        
        yield return new WaitForSeconds ( boxAnimator.GetCurrentAnimatorClipInfo ( 0 ).Length * 0.5f );
        

        PlayLightRaysAnimation ();
        PlayBottleAnimation ();

        yield return new WaitForSeconds ( 1.25f );

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
