using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTest : MonoBehaviour
{
    // Start is called before the first frame update

    public float enemyLife = 100f;
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet01fromPlayer"))
        {
            if(enemyLife < 1)
            {
                Destroy(col.gameObject);
                Destroy(gameObject);
            }
        else
            {
                enemyLife = enemyLife - 25f;
            }
        }
    }
}
