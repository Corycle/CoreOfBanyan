using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    static MKeySetClass k0 = new(0, 0, 0, 0, 0, 0);

    static MKeySetClass k1 = new(KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D, KeyCode.Alpha1, KeyCode.Alpha2);

    static MKeySetClass k2 = new(KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.Comma, KeyCode.Period);

    InitialStatus init = new(10, 6, new() { 0, 0, 2, 2, 2, 2 }, new() { k1, k2, k0, k0, k0, k0 });
    void Start()
    {

    }

    double curtime = -114;

    // Update is called once per frame
    void Update()
    {
        if (transform.gameObject.GetComponent<ClickScript>().isCollision() && Input.GetMouseButtonDown(0))
        {
            curtime = Time.timeAsDouble;
        }
        if (Time.timeAsDouble - curtime < 0.4)
        {
            ManageGameManager.gameStatus = false;
            ManageGameManager.init = init;
            Camera.main.GetComponent<ManageGameManager>().EndGame();
            ManageGameManager.isTutorial = false;
            Camera.main.GetComponent<ManageGameManager>().ChangeDisplayStatus(null);
            ManageGameManager.gameStatus = true;
        }
    }
}
