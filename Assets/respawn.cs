using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Transform Player;
    public Transform respawnPoint;
    // Start is called before the first frame update
   void OnTriggerEnter (Collider collider)
    {
        Player.transform.position = respawnPoint.transform.position;
    }
}
