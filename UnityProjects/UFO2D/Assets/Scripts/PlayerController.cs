using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float playerspeed;
    private int count = 0;
    public Text countText;
    public Text WinText;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        WinText.text = "";
        SetCountText();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * playerspeed);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PickUp"))
        {
            Destroy(collision.gameObject);
            count += 1;
            SetCountText();
            if (count == 8)
            {
                WinText.text = "You WIN!";
            }
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

}
