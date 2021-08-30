using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    private Animator anim;
    [SerializeField]
    private bool sound_Check;
    [SerializeField]
    private Image audio_image;
    [SerializeField]
    private Sprite sound_On;
    [SerializeField]
    private Sprite sound_Off;
    [SerializeField]
    private AudioSource audio_source;
    [SerializeField]
    private GameManager gameManager;
    private void Start()
    {
        sound_Check = true;
    }
    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    public void SoundControl()
    {
        sound_Check = !sound_Check;
        if (sound_Check)
        {
            audio_image.sprite = sound_On;
            audio_source.Play();
        }
        else
        {
            audio_image.sprite = sound_Off;
            audio_source.Stop();
        }
    }
    public void GameStart()
    {
        anim.Play("Start_UI_Hide");
        StartCoroutine(PlayableMode());
    }
    IEnumerator PlayableMode()
    {
        yield return new WaitForSeconds(0.5f);
        gameManager.current_Statues = GameManager.GameStatus.PLAYING;
    }
}
