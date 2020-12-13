using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Çarpışma oldu");
        if (collision.collider.tag == "Enemy")
        {
            GameManager.Instance.health -= 1;
            Destroy(collision.gameObject);
        }
        else if (collision.collider.tag == "Healing")
        {
            GameManager.Instance.health += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.collider.tag == "Key")
        {
            Destroy(collision.gameObject);
        }
    }


}
