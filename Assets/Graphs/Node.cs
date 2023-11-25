using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   
   public list<Edge> edgeList = new list<Edge> ();
   public Node path = null;
   GameObject id;
   public float xPos;
   public float yPos;
   public float zPos;

   public float f, g, h;
   public Node camefrom;

   public Node(GameObject i)
    {
        id = i;
        xPos = i.transform.position.x;
        yPos = i.transform.position.y;
        zPos = i.transform.position.z;
        path = null;
    }

    public GameObject getId()
    {
        return id;
    }



}
