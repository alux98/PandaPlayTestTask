using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationManager : MonoBehaviour
{
    public Animator buttonAnimator;
    public Animator lightRaysAnimator;
    public Animator surpriseBoxTextAnimator;
    public Animator [] newToppingTextAnimator;

    public void PlayAnimationsOnClick ()
    {
        StartCoroutine ( PlayAnimations () );
    }

    public IEnumerator PlayAnimations ()
    {
        PlayButtonScaleDownAnimation ();

        yield return new WaitForSeconds ( 2 );

        PlayLightRaysAnimation ();

        yield return new WaitForSeconds ( 1 );

        PlayTextAnimations ();

        yield return new WaitForSeconds ( 2 );

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
}
