using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode JumpKey;
    public Rigidbody2D RB;
    public int JumpForce;
    public int Score = 0;
    public TMP_Text TextObject;
    public GameObject GameOverPanel;

    //ass

    private void Start()
    {
        TextObject.text = "Score: " + Score;
    }
    void Update()
    {
        if (Input.GetKeyDown(JumpKey))
        {
            RB.velocity = new Vector3(0, JumpForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipes")
        {
            GameOverPanel.SetActive(true);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Coin")
        {
            Score++;
            TextObject.text = "Score: " + Score;
            Destroy(collision.gameObject);
        }
    }

}
