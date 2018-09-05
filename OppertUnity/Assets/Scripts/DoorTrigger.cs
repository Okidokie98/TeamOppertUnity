using System.Collections;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

    TriggerDoor DoorScript;
    public GameObject DoorObject;

    void Start () {
        DoorScript = DoorObject.GetComponent <TriggerDoor> ();
    }

    void OnTriggerEnter (Collider other) {
        DoorScript.DoorOpen ();
    }

    void OnTriggerExit (Collider other) {
        DoorScript.DoorOpen ();
    }
}