using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameManager game_Manager;
    [SerializeField]
    private float movement_speed;
    [SerializeField]
    private float horizontal_Speed;
    private Rigidbody my_Body;
    public bool canMove;
    public bool check;
    private bool press_check;
    private void Awake()
    {
        my_Body = gameObject.GetComponent<Rigidbody>();
    }
    void Start()
    {
        check = false;
        canMove = true;
        movement_speed = 0;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            press_check = true;

        }
        if (Input.GetMouseButtonUp(0))
        {
            press_check = false;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (game_Manager.GetComponent<GameManager>().current_Statues == GameManager.GameStatus.PLAYING)
        {
            if (canMove)
            {
                MoveStraight();
                MoveLeftRight();
            }
            else
            {
                my_Body.velocity = Vector3.zero;
            }
          
        }
    }
    void MoveStraight()
    {
        movement_speed = 10;
        my_Body.velocity = new Vector3(my_Body.velocity.x, my_Body.velocity.y, movement_speed);
        Vector3 temp_x = transform.position;
        temp_x.x = Mathf.Clamp(temp_x.x, 78.41927f, 95.23952f);
        transform.position = temp_x;
    }
    void MoveLeftRight()
    {
        if (press_check)
        {
            my_Body.velocity = new Vector3(Input.GetAxisRaw("Mouse X") * horizontal_Speed, my_Body.velocity.y, my_Body.velocity.z);
        }
    }
}
