using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotation2 : MonoBehaviour
{
    private InputPlayer inputArma;
    public float horizontal;
    public float vertical;
    public Animator armaAnimator;

    private void Update()
    {
        horizontal = inputArma.ejeHorizontal;
        vertical = inputArma.ejeVertical;


    }
    
}

