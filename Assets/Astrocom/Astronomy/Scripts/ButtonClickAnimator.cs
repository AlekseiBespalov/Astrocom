using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonClickAnimator : MonoBehaviour
{
    public Animator animator;

    private AnimatorStateInfo planetState;

    private bool AnimationPlayed = false;
    void Start()
    {
        animator = animator.GetComponent<Animator>();
    }

    private void Update()
    {
        planetState = animator.GetCurrentAnimatorStateInfo(0);
    }

    private void OnMouseDown()
    {
        //Touch touch;
        //touch = Input.GetTouch(0);
        //int pointerID = touch.fingerId;

        //if (Input.touchCount == 1 && !EventSystem.current.IsPointerOverGameObject(pointerID))
        //{
        //    CheckStateAnimation(planetState.normalizedTime);
        //}
        CheckStateAnimation(planetState.normalizedTime);
    }

    public void PlayAnimation(float normalizedTime)
    {
        animator.SetFloat("Direction", 1);
        animator.Play("planetAnimation", 0, normalizedTime);
        AnimationPlayed = true;
    }

    public void ReversePlayAnimation(float normalizedTime)
    {
        animator.SetFloat("Direction", -1);
        animator.Play("planetAnimation", 0, normalizedTime);
        AnimationPlayed = false;
    }

    public void CheckStateAnimation(float normalizedTime)
    {
        float playTime = normalizedTime;
        if(AnimationPlayed == false && (normalizedTime > 1 || normalizedTime < 0)) //if unity goes beyond the bounds of animation,
        {
            playTime = 0.0f;    //then we reset the counter to the timepoint (to start of animation) that is needed
            PlayAnimation(playTime);
            return;
        }
        else if(AnimationPlayed == true && normalizedTime > 1)  // here we reset time to the end of animation
        {
            playTime = 1.0f;
            ReversePlayAnimation(playTime);
            return;
        }
        else if(AnimationPlayed == false && (normalizedTime > 0 && normalizedTime < 1))
        {
            playTime = normalizedTime;
            PlayAnimation(playTime);
            return;
        }
        else if(AnimationPlayed == true && (normalizedTime > 0 && normalizedTime < 1))
        {
            playTime = normalizedTime;
            ReversePlayAnimation(playTime);
            return;
        }
    }
}
