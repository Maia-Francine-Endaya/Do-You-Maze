using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  Rigidbody rb;
  [SerializeField] float movementSpeed = 6f;

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

      //Player health
      //This is a test as there are no obstacles yet
      if (Input.GetKeyDown(KeyCode.Space))
      {
        TakeDamage(1);
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
