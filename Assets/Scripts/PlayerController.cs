using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    /// <summary>Sets player's speed</summary>
    public float speed = 10.0f;
    ///<summary>Set's Players health (default of 5)</summary>
    public int health = 5;
    ///<summary>Sets text for score in display</summary>
    public Text scoreText;
    ///<summary>Sets text for health display</summary>
    public Text healthText;
    private Rigidbody rb;
    private int score = 0;

    ///<summary>Adds an instance of CharacterController to Player at start</summary>
    void Start()
    {
        //controller = gameObject.AddComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>handles controller movement</summary>
    void FixedUpdate()
    {
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //controller.Move(move * Time.deltaTime * speed);
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, Input.GetAxis("Vertical") * speed);
    }

    ///<summary>Moves game object when keys WASD or arrow keys are pressed</summary>
    void Update()
    {
        // Checking health before moving
        if (health == 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("maze");
        }
    }

    ///<summary>Inriments score when Player touches object called "Pickup," decriments health when player touches object tagged "Trap." Handles win.</summary>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Pickup")
        {
            score += 1;
            SetScoreText();
            // Debug.Log($"Score: {score}");
            Destroy(other.gameObject);
        }

        if (other.tag=="Trap")
        {
            health--;
            SetHealthText();
            //Debug.Log($"Health: {health}");
        }

        if (other.gameObject.tag=="Goal")
        {
            Debug.Log("You win!");
        }
    }

    /// <summary>Updates player's score in text</summary>
    void SetScoreText()
    {
        scoreText.text = $"Score: {score}";
    }

    ///<summary>Updates player's health in text</summary>
    void SetHealthText()
    {
        healthText.text = $"Health: {health}";
    }

    /// <summary>Destroys controller on disable</summary>
    public void OnDisable()
    {
        //Destroy(controller);
    }
}
