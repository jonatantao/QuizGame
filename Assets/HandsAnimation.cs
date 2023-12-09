using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandsAnimation : MonoBehaviour
{
    [SerializeField] private InputActionReference gripReference;
    [SerializeField] private Animator handAnimator;
    
    // Update is called once per frame
    void Update()
    {
        float gripValue = gripReference.action.ReadValue<float>();
        
    }
}
