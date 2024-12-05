using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxManager : MonoBehaviour
{
    public float BoxCooldown = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 10 * Time.deltaTime, 10 * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collided with");
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Invoke("showBox", BoxCooldown);
        }
    }

    private void showBox()
    {
        gameObject.SetActive(true);
    }
}
