using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphs : MonoBehaviour
{
    List<Edge> edges = new List<Edge>();
    List<Node> nodes = new List<Node> (); 
    List<Node> pathList = new List<Node> () ;

    public Graph() { }

    public void AddNode(GameObject id)
    {
        Node node = new Node(id);
        nodes.Add(node);

        if(from != null && to != null)
        {
            Edge e = new Edge(from, to);
            edges.Add(e);
            from.edgeList.Add(e);
        }
     
            
    }

    public void AddEdge (GameObject fromNode, GameObject toNode)
    {
        Node from = findNode(fromNode);
        Node to = FindNode(toNode);   
    }
    Node FindNode(GameObject id)
    {
        foreach(Node n in nodes)
        {
            if (n.getId() == id)
                return n;
        }
        return null;
    }
}
