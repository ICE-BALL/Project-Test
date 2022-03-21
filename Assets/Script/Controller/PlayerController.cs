using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Stat _playerStat = new Stat();

    enum PlayerState
    {
        Idle,
        Run,
        Attack,
    }

    PlayerState state = PlayerState.Idle;

    // right hand
    GameObject Parent;

    // Item ( Sword )
    GameObject Sword_Iron;
    GameObject Sword_Ice;

     int ItemCount = 0;

    void Start()
    {
        Managers.Input.KeyAction -= Move;
        Managers.Input.KeyAction += Move;

        Iron_Canvas.Iron -= Change_Iron;
        Iron_Canvas.Iron += Change_Iron;

        Ice_Canvas.Ice -= Change_Ice;
        Ice_Canvas.Ice += Change_Ice;

        Managers.UI.ShowSceneUI<Bag>();
        Managers.UI.ShowSceneUI<Sword_On_Off>();

        Parent = GameObject.Find("Character1_RightForeArm");
        Sword_Iron = Managers.Resource.Instantiate("MagicSword_Iron", Parent.transform);
        Sword_Ice = Managers.Resource.Instantiate("MagicSword_Ice", Parent.transform);

        Sword_Iron.SetActive(false);
        Sword_Ice.SetActive(false);
    }

    void Update()
    {
        switch (state)
        {
            case PlayerState.Idle:
                Idle();
                break;
            case PlayerState.Run:
                Run();
                break;
        }

        if (Input.anyKey != true) { state = PlayerState.Idle; }
        Attack();

        //Debug.Log($"Hp : {_playerStat.Hp} / Attack : {_playerStat.Attack}");
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            state = PlayerState.Run;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.5f);
            transform.position += Vector3.forward * _playerStat.Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            state = PlayerState.Run;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.5f);
            transform.position += Vector3.back * _playerStat.Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            state = PlayerState.Run;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.5f);
            transform.position += Vector3.right * _playerStat.Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            state = PlayerState.Run;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.5f);
            transform.position += Vector3.left * _playerStat.Speed * Time.deltaTime;
        }
    }

    void Idle()
    {
        Animator anim = GetComponent<Animator>();
        anim.SetFloat("speed", 0);
    }

    void Run()
    {
        Animator anim = GetComponent<Animator>();
        anim.SetFloat("speed", 10.0f);
    }

    void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Animator anim = GetComponent<Animator>();
            anim.SetBool("Sword", true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Animator anim = GetComponent<Animator>();
            anim.SetBool("Sword", false);
        }

    }

    void Change_Iron()
    {
        if (ItemCount == 0)
        {
            _playerStat.Hp += 15;
            _playerStat.Attack += 5;
            Sword_Iron.SetActive(true);
            ItemCount = 1;
        }
        else if (ItemCount == 1)
        {
            _playerStat.Hp -= 15;
            _playerStat.Attack -= 5;
            Sword_Iron.SetActive(false);
            ItemCount = 0;
        }
    }

    void Change_Ice()
    {
        if (ItemCount == 0)
        {
            _playerStat.Hp += 10;
            _playerStat.Attack += 10;
            Sword_Ice.SetActive(true);
            ItemCount = 2;
        }
        else if (ItemCount == 2)
        {
            _playerStat.Hp -= 10;
            _playerStat.Attack -= 10;
            Sword_Ice.SetActive(false);
            ItemCount = 0;
        }
    }
}
