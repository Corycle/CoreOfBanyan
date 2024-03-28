using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CustomBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (transform.gameObject.GetComponent<ClickScript>().isCollision() && Input.GetMouseButtonDown(0))
        {
            Camera.main.GetComponent<ManageGameManager>().withdrawDisplayStatus(new() { 3 });
            var t = Camera.main.GetComponent<ManageGameManager>().displayObjects[0].transform;
            t.GetChild(2).GetChild(0).GetChild(0).GetComponent<ClickScript>().isActive = false;
            t.GetChild(3).GetChild(0).GetChild(0).GetComponent<ClickScript>().isActive = false;
            Camera.main.GetComponent<ManageGameManager>().DisplayStatus(new() { 6 });
        }
    }
}
