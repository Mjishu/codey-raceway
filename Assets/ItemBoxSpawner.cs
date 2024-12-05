using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;
    public int numberOfBoxes;

    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
            Vector3 offset = new Vector3(5 * i + 1, 0, 0);
            GameObject itemBoxClone = Instantiate(itemBox, transform.position + offset, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
