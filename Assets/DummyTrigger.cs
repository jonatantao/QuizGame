using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] targetDummies;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Weapon"))
        {
            foreach(GameObject dummies in targetDummies)
            {
                dummies.GetComponent<TargetDummy>().ActivateDummy();
            }
        }
    }
}
