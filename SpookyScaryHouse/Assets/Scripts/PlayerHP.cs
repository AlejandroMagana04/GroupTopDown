using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {
    public int hp = 10;
    public Text healthText;
    public Slider healthbar;

    void Start()
    {
        healthText.GetComponent<Text>().text = "Health:" + hp;
        healthbar.GetComponent<Slider>().value = hp;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hp--;
            healthText.GetComponent<Text>().text = "Health:" + hp;
            healthbar.GetComponent<Slider>().value = hp;
            if (hp <= 0)
            {
                SceneManager.LoadScene("Lose");
            }
        }
        else if (collision.gameObject.tag == "Heal")
        {
            hp++;
            healthText.GetComponent<Text>().text = "Health:" + hp;
            healthbar.GetComponent<Slider>().value = hp;
            Destroy(collision.gameObject);
        }
    }

       
}
