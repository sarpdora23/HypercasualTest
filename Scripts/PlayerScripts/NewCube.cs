using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCube : MonoBehaviour
{
    private void Start()
    {
        Invoke("DeactiveObject", 3);
    }
    void DeactiveObject()
    {
        Destroy(gameObject);
    }
}
