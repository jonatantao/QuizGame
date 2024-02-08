using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    [SerializeField] private Animator dummyAnimator;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Arrow") || other.gameObject.CompareTag("Weapon")) {
            dummyAnimator.SetTrigger("Death");
        }
    }

    public void ActivateDummy() {
        dummyAnimator.SetTrigger("Activate");
    }
}
