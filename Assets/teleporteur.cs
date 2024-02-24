using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporteur : MonoBehaviour
{
    [SerializeField] private Transform destination;

    public Transform GetDestination()
    {
        return destination;
    }
}