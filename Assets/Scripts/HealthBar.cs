using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public int health;//keeps track if the player's current health
    public Text text;
    [SerializeField] AudioSource death;

    //for setting up max health so that we don't have alter it always
    // checking if the health becomes less than 0. If so, rendering the next scene. 

    void Start() {
        AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
        death = allMyAudioSources[0];
    }

    void Update() {
        if(slider.value <= 0) {
            death.Play(0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health; //find the slider and adjust the value in bar to the value we set
        //text.text = "Health"+health;
    }

  
}
