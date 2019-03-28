using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticles : MonoBehaviour
{
    [SerializeField] private GameObject bubbles;
    [SerializeField] private Transform spawnPosition;

    public void StartParticlesSystem(){
        Instantiate<GameObject>(bubbles, spawnPosition.position, Quaternion.identity);
    }
}
