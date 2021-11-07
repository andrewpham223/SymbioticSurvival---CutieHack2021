using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    
    private float minX, maxX, minY, maxY;
    
    
    void Start()
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
         Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0,0, camDistance));
         Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1,1, camDistance));
         
         minX = bottomCorner.x;
         maxX = topCorner.x;
         minY = bottomCorner.y;
         maxY = topCorner.y;
    }

    void Update()
    {  
         // Get current position
         Vector3 pos = transform.position;
 
         
         if(pos.x < minX) pos.x = minX;
         if(pos.x > maxX) pos.x = maxX;
 
        
         if(pos.y < minY) pos.y = minY;
         if(pos.y > maxY) pos.y = maxY;
 
         
         transform.position = pos;
    }
}
