using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationShifter : MonoBehaviour
{

    public Animator anim;
    void Update()
    {
        anim.SetFloat("Vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

    }
}
