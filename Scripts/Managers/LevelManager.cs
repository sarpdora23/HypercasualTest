using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public int level_Stage;
    [SerializeField]
    private GameObject stage1_items;
    [SerializeField]
    private GameObject stage2_items;
    [SerializeField]
    private GameObject stage3_items;
    [SerializeField]
    private Player player;
    private void Start()
    {
        level_Stage = 0;
    }
    public void NextStage()
    {
        if (level_Stage == 1)
        {
            Destroy(stage1_items);
            
        }
        else if (level_Stage == 2)
        {
            Destroy(stage2_items);
            
        }
        else if (level_Stage == 3)
        {
            SceneManager.LoadScene("SampleScene");
        }
        level_Stage++;
        player.canMove = true;
    }
}
