using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float velocity;
    public GameObject playButton;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * velocity;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;

        SceneManager.LoadScene(0);
    }

    public void startGame()
    {
        playButton.SetActive(false);
        Time.timeScale = 1;
    }
}
