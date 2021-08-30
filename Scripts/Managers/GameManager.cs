using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public GameStatus current_Statues;
    [SerializeField]
    private LevelManager level_Manager;
    [SerializeField]
    private GameObject start_ui;
    // Start is called before the first frame update
    void Start()
    {
        current_Statues = GameStatus.START; //When game start, current statue equal START
    }

    // Update is called once per frame
    void Update()
    {
        switch (current_Statues)
        {
            case GameStatus.START:
                StartGame();
                break;
            case GameStatus.SHOP:
                Shop();
                break;
            case GameStatus.ADD:
                Add();
                break;
            case GameStatus.PLAYING:
                PlayingGame();
                break;
            case GameStatus.FINISH:
                FinishGame();
                break;
        }
        //Check game current state
    }
    void Add()
    {

    }
    void StartGame()
    {
        start_ui.SetActive(true);
    }
    void Shop()
    {

    }
    void PlayingGame()
    {
        start_ui.SetActive(false);
    }
    void FinishGame()
    {

    }
    public void Win(GameObject pool)
    {
        Animator anim = pool.GetComponent<Animator>();
        anim.Play("Pool_Win");
        StartCoroutine(WaitNewStage());
    }
    IEnumerator WaitNewStage()
    {
        yield return new WaitForSeconds(0.8f);
        level_Manager.NextStage();
    }
    public enum GameStatus
    {
        START,
        SHOP,
        ADD,
        PLAYING,
        FINISH,
    }
}
