using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public enum Neighbor{
    Left = 1,
    Right = 2,
    LUp = 4,
    RUp = 8,
    LDown = 16,
    RDown = 32
};
public class NeighborPos{
    static public Vector2Int Left=new(-1,-1), Right=new(1,1), RUp=new(1,0), LDown=new(-1,0), RDown=new(0,1), LUp=new(0,-1);
}
public class LandBehaviour : MonoBehaviour
{

    public List<Color> colors;
    // Start is called before the first frame update
    public int owner;
    public int hp;
    public Neighbor neighbor;

    void Awake()
    {
        owner = -1;
        hp = 3;
        colors = new(){Color.green, Color.red};
        neighbor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool CanBeCapturedBy(float energy) {
        return energy >= hp;
    }
    public void ChangeImg() {
        Debug.Log(owner);
        Debug.Log(colors);
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        Sprite t = Resources.Load<Sprite>(String.Format("Textures/{0}",(int)neighbor));
        s.color = colors[owner];
        s.sprite = t;
    }
}
