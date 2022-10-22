using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRB;

    public float playerSpeed;

    private Vector3 playerPosChange;

    void Start()
    {
       playerRB = GetComponent<Rigidbody2D>();
       
    }

    
    void Update()
    {
        playerPosChange = Vector3.zero;
        playerPosChange.x = Input.GetAxis("Horizontal");
        playerPosChange.y = Input.GetAxis("Vertical");
        if(playerPosChange != Vector3.zero)
        {
            PlayerMov();
        }
    }

    void PlayerMov()
    {
       playerRB.MovePosition (transform.position + playerPosChange * playerSpeed * Time.fixedDeltaTime);
    }
}
