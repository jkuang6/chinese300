using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public Image healthBar;
    private float timer;
    public float currentHealth;
    public float totalHealth;
    public float delay;
    public AudioSource panting;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentHealth);

        timer += Time.deltaTime;
        if (timer >= delay)
        {
            currentHealth = currentHealth - 1;
            healthBar.fillAmount = currentHealth / totalHealth;
            if (currentHealth <= 3)
            {
                panting.Play();
            }

            if (currentHealth > 3)
            {
                panting.Stop();
            }
            timer = 0f;
        }

        if (currentHealth == 0)
        {
            SceneManager.LoadScene("Death Screen");
        }
    }

    public void addWater()
    {
        Debug.Log(currentHealth);
        currentHealth = currentHealth + 2;
        if (currentHealth > 10)
        {
            currentHealth = 10;
        }
        healthBar.fillAmount = currentHealth / totalHealth;
    }


}
