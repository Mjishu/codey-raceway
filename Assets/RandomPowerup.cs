using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;

    public GameObject chosenPowerup;

    void Update()
    {
        if (Input.GetButtonDown("Jump") && chosenPowerup)
        {
            Vector3 zOffset = new Vector3(0, 3, -5);
            Instantiate(chosenPowerup, transform.position + zOffset, transform.rotation);
            chosenPowerup = null;
        }
        else if (Input.GetButtonDown("Jump") && !chosenPowerup)
        {
            Debug.Log("get a power up!");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ItemBoxes"))
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
