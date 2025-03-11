using UnityEngine;
using TMPro;

public class BulletScript : MonoBehaviour
{
    public int points; 
    public AudioClip audioClip;
    //public AudioSource audioSource;
    public bool hitPerson = false;

    public TextMeshProUGUI pointsText;

    public float survivalTime; //How long the bullet will be allowed to fly before it deletes itself

    void OnCollisionEnter(Collision collision)
    {
        //AudioSource.PlayClipAtPoint(audioClip, transform.position);
        Destroy(gameObject); // Destroy bullet on impact with anything with a collider
       
        Debug.Log("You hit: " + collision.gameObject.name); // prints out name of the object the bullet hits
       
        
        //if bullet hits object tagged person call update points
        if(collision.gameObject.tag == "Person")
        {
            //audioSource.Play();
            
            hitPerson = true;
            Debug.Log("hit person is: " + hitPerson);
            UpdatePoints();
        }
            

        
    }

    void Start()
    {
        Destroy(gameObject, survivalTime); // Automatically destroy bullet after survivalTime is up

    }

    void UpdatePoints()
    {
        //Debug.Log("we are in the update function");
        //if (pointsText!= null) //assumes we have a reference to some text in the canvas
        //{
            if (hitPerson == true)
            {
                Debug.Log("Add points");
                //ammoText.text = currentAmmo + " / " + maxAmmo; //if we're not reloading "show currentammo / maxammo"
                points += 1;
                pointsText.text = "Points: " + points;
                hitPerson = false;
            }
            else
            {
                //else do nothing essentially
                pointsText.text = "Points: " + points;
                //ammoText.text = "Reloading... / " + maxAmmo; //if reloading show that we're reloading. TOtally customize this how you like
            }
       // }
    }
    
}
