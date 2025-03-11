using UnityEngine;

//public class expointscript : MonoBehaviour
public class CollisionHandler : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public bool hitHotdog;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hotdog")
        {
            hitHotdog = true;
            Destroy(gameObject);
        }
        
        
    }

}
    



