/**
Waypoints
sets waypoints
 Author: Conor
 Colab: brackeys tutorial
 Date: 12/17/21
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
/** instance data **/
public static Transform[] points;

/** sets points to move to with arraylist **/
void Awake ()
    	{
    		points = new Transform[transform.childCount];
    		for (int i = 0; i < points.Length; i++)
    		{
    			points[i] = transform.GetChild(i);
    		}
    	}


}
