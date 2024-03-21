using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VRTeleport : MonoBehaviour
{
    public GameObject player;
    public GameObject hand;
    public Transform dest;
    public NavMeshAgent agent;


    public GameObject teleportRing;
    public GameObject teleportlineCast;

    [Header("Teleport Settings")]
    [Space(10)]
    public float teleportDistance;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StartCoroutine(Teleport(hand.transform));

        //Test rotate function
        player.transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * 2f);
        hand.transform.Rotate(Vector3.right, Input.GetAxis("Vertical") * 2f);

    }


    public IEnumerator Teleport(Transform origin)
    {
        teleportRing.SetActive(true);
        teleportlineCast.SetActive(true);

        var blocked = true;

        while (!Input.GetKeyUp(KeyCode.Space))
        {
            //Show line, update dest

            //Update Dest:
            NavMeshHit hit;
            
            blocked = NavMesh.Raycast(origin.position, origin.forward * teleportDistance, out hit, NavMesh.AllAreas);
            Debug.DrawLine(origin.position, dest.position, blocked ? Color.red : Color.green);

            if (!blocked)
                dest.position = hit.position;
            
            teleportRing.SetActive(!blocked);
            teleportRing.transform.position = dest.position;
            //TODO figure out how to do line.end = dest.position;

           
            yield return null;
        }


        teleportRing.SetActive(false);
        teleportlineCast.SetActive(false);

        if(!blocked)
            DoTeleport();

    }

    void DoTeleport()
    {
        player.transform.position = dest.position + new Vector3(0f, 1f, 0f);
    }


}
