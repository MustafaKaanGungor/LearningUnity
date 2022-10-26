using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRB;

    public float playerSpeed;

    private Vector3 playerPosChange;

    private Animator playerAnim;
    void Start()
    {
       playerRB = GetComponent<Rigidbody2D>();
       playerAnim = GetComponent<Animator>();
    }

    
    void Update()
    {
        playerPosChange = Vector3.zero;
        playerPosChange.x = Input.GetAxis("Horizontal");
        playerPosChange.y = Input.GetAxis("Vertical");
        UpdateAnims();
    }

    void UpdateAnims()
    {
        if(playerPosChange != Vector3.zero)
        {
            PlayerMov();
            playerAnim.SetFloat("moveX", playerPosChange.x);
            playerAnim.SetFloat("moveY", playerPosChange.y);
            playerAnim.SetBool("Walking", true);
        }
        else{
            playerAnim.SetBool("Walking",false);
        }
    }
    void PlayerMov()
    {
    playerRB.MovePosition (transform.position + playerPosChange * playerSpeed * Time.fixedDeltaTime);
    }
}
