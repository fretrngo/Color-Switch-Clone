using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sp; 

    public float magnitude= 5f;
    public string color;

    public Color red=Color.red;
    public Color yellow=Color.yellow;
    public Color magenta=Color.magenta;
    public Color cyan=Color.cyan;
    private void Start()
   {
        sp.color =red;
        color="red";
    } 

    private void Update()
    {
        if(Input.GetButtonDown("Jump")){
            rb.velocity = Vector2.up * magnitude;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.TryGetComponent<Obstacle>(out Obstacle obs))
        {
            if (obs.color != color)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(collider.gameObject.TryGetComponent<ColorSwitcher>(out ColorSwitcher switcher))
        {
            sp.color = switcher.color;
            color = switcher.colorName;
            Destroy(switcher.gameObject);
        }
    }

}
