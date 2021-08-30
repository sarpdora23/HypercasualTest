using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolControlCheck : MonoBehaviour
{
    [SerializeField]
    private Player player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PoolControl")
        {
            player.canMove = false;
            other.gameObject.transform.parent.gameObject.GetComponentInChildren<Pool>().Controll();
            Debug.Log("Test??");
        }
    }
}
