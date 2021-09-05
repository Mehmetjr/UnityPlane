using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public bool active;
    public GameObject[] objects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            Invoke("roadTransfer", 4);
            active = false;
        }
    }

    void roadTransfer()
    {
        float altDogmasayi = Random.Range(0, 2);
        float ustDogmasayi = Random.Range(0, 2);
        if (altDogmasayi == 1)
        {
            objects[1].SetActive(false);
        }
        else
        {
            objects[1].SetActive(true);
        }

        if (ustDogmasayi == 1)
        {
            objects[2].SetActive(false);
        }
        else
        {
            objects[2].SetActive(true);
        }

        objects[0].transform.localPosition = new Vector2(Random.Range(-18f,-3.5f),-8);
        transform.position = transform.position + new Vector3(112f, 0, 0);
    }
}
