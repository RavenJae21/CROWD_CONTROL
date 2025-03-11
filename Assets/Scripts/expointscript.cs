using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

void OnCollisionEnter()
{
if (col.gameObject.tag == "Expoints")
{
    Destroy(gameObject);
}
}
