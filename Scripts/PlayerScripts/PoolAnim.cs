using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolAnim : MonoBehaviour
{
    public void DestroyGates(GameObject gate)
    {
        gate.SetActive(false);
    }
}
