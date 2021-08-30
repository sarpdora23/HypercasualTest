using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pool : MonoBehaviour
{
    public int item_Count;
    public int need_Count;
    [SerializeField]
    private Text pool_Text;
    [SerializeField]
    private GameManager game_Manager;
    [SerializeField]
    private GameObject pool;
    public List<GameObject> items_in_pool;
    [SerializeField]
    private GameObject new_item;
    private void Start()
    {
        item_Count = 0;
        pool_Text.text = item_Count.ToString() + "/" + need_Count.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            item_Count++;
            pool_Text.text = item_Count.ToString() + "/" + need_Count.ToString();
        }
    }
    public void Controll()
    {
        StartCoroutine(CollectWait());
    }
   
    IEnumerator CollectWait()
    {
        yield return new WaitForSeconds(4);
        if (item_Count >= need_Count)
        {
            DestroyItems();
            StartCoroutine(WaitWin());
        }
        else
        {
            
        }
    }
    void DestroyItems()
    {
        foreach (GameObject item in items_in_pool)
        {
            GameObject newCube = GameObject.Instantiate(new_item, item.transform.position, Quaternion.identity);
            item.SetActive(false);
        }
    }
    IEnumerator WaitWin()
    {
        yield return new WaitForSeconds(1.5f);
        game_Manager.Win(pool);
    }
}
