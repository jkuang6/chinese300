using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Image healthBar;
    private float timer;
    public float currentHealth;
    public float totalHealth;
    public float delay;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay)
        {
            currentHealth = currentHealth - 1;
            healthBar.fillAmount = currentHealth / totalHealth;
            timer = 0f;
        }
    }

    public void addWater()
    {
        Debug.Log("water called");
        currentHealth = currentHealth + 2;
    }


}
