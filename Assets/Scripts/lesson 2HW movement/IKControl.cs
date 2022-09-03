using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class IKControl : MonoBehaviour
{
    protected Animator animator;
    private bool flag = false;
    [SerializeField] Transform rightHandObj;
    [SerializeField] Transform lookObj;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnAnimatorIK()
    {
        if (animator!=null)
        {
            if ((rightHandObj.position-lookObj.position).magnitude<2)
            {
                if (lookObj != null)
                {
                    animator.SetLookAtWeight(0.7f);
                    animator.SetLookAtPosition(lookObj.position);
                }
                if (rightHandObj != null)
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0.7f);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0.7f);
                    animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation);
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "InterestingStuff")
        {
            flag = true;
            lookObj = other.transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "InterestingStuff")
        {
            flag = false;
            lookObj = null;
        }
    }
}