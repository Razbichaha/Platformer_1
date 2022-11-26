using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlaer : MonoBehaviour
{
    private const string AnimationWalk = "Walk";
    private const string AnimationRun = "Run";

    [SerializeField] private Animator _animator;

    public void RunStart()
    {
        _animator.SetBool(AnimationRun, true);
    }

    public void RunStop()
    {
        _animator.SetBool(AnimationRun, false);
    }

    public void WalkLeft()
    {
        _animator.SetBool(AnimationWalk, true);
    }

    public void WalkRight()
    {
        _animator.SetBool(AnimationWalk, true);

    }

    public void WalkStop()
    {
        _animator.SetBool(AnimationWalk, false);
    }
}
