using UnityEngine;

//public class expointscript : MonoBehaviour
public class CollisionHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject)
    }

if (collision.gameObject.tag == "Hotdog")
{
    hitHotdog = true;
    Destroy(CollisionHandler.gameObject)
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
