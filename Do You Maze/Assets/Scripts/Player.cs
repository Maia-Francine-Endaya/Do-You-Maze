using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  Rigidbody rb;
  [SerializeField] float movementSpeed = 6f;
  [SerializeField] float jumpForce = 5f;

  public int maxHealth = 5;
  public int currentHealth;

  public HealthBar health;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      currentHealth = maxHealth;
      health.SetMaxHealth(maxHealth);   
    }

    // Update is called once per frame
    void Update()
    {
      //Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

      
      if (Input.GetKeyDown("space"))
      {
        rb.velocity  = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
      }

      void TakeDamage(int damage)
      {
        currentHealth -= damage;
        health.SetHealth(currentHealth);
      }

      if (currentHealth == 0) {
        SceneManager.LoadScene(2);
      }
    }
}
