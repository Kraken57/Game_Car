using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class Player : MonoBehaviour
{
    public GameManagerScript gameManger;
    public int maxHealth = 100;
    public int currentHealth;
    public int health;
    

    private bool isDead;

    public HealthBar healthBar;
    [SerializeField] AudioSource HealthBarDecreaseSound;
    [SerializeField] AudioSource HealthBarIncreaseSound;
    //[SerializeField] AudioSource death;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;//Set your current health to full 
        healthBar.SetMaxHealth(maxHealth); //setting up our health bar 
        AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
        HealthBarDecreaseSound = allMyAudioSources[0];
        HealthBarIncreaseSound = allMyAudioSources[1];
        //death = allMyAudioSources[1];
    }

    //Game Over Scree
    void Update()
    {
        if (health <=0  && !isDead)
        {
            isDead = true;
            gameManger.gameOver();
            Debug.Log("DEAD");
        }
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision obj)
    {
        if(obj.gameObject.tag == "Enemy");
        {
            currentHealth -= 10;
            healthBar.SetHealth(currentHealth);
            // HealthBarDecreaseSound.Play(0);
        }
    }

        // if(slider.value <= 0) {
        //     death.Play(0);
        //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // }
    //     // but how are you detecting collison by same tag as player ? 
    //     // if (Input.GetKeyDown(KeyCode.Space))
    //     // {
    //     //     TakeDamage(20);
    //     // }
    // }

    // // yaha par aaja 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Health")) {
            Destroy(other.gameObject);
            // HealthBarIncreaseSound.Play(0);  
            currentHealth += 20;
            healthBar.SetHealth(currentHealth);
        }
    }

    // public void IncreaseHealth(int health)
    // {
    //     currentHealth += health;

    //     healthBar.SetHealth(currentHealth);
    // }
    


     
    //This function will be called anytime the player takes damage
    // void TakeDamage(int damage) //damage = how much damage the player takes 
    // {
    //     currentHealth -= damage;

    //     healthBar.SetHealth(currentHealth);
    // }
}
