using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFire : MonoBehaviour
{ 
    [SerializeField] private GameObject arrow;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float arrowSpeed = 10f;

    public void ShootArrow() {
        GameObject spawnArrow = Instantiate(arrow, spawnPoint.position, spawnPoint.rotation);
        spawnArrow.GetComponent<Rigidbody>().velocity = spawnPoint.forward * arrowSpeed;
        Destroy(spawnArrow, 5f);
    }
}
