using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pool")
        {
            collision.gameObject.GetComponent<Pool>().items_in_pool.Add(gameObject);
        }
    }
}
