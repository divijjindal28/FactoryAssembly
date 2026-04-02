using UnityEngine;

public class MoveToSpawnPointChild : MonoBehaviour
{
    public GameObject objectToMove;
    public Transform referencePoint;
    public GameObject gameObject;

void Start()
    {
        Debug.Log("MoveToSpawnPointChild: Start() called");

        Invoke(nameof(MoveToSpawnPointMethod1), 1f);

        Debug.Log("MoveToSpawnPointChild: Invoke scheduled for MoveToSpawnPointMethod after 1 second");
    }

    void MoveToSpawnPointMethod0()
    {
        Debug.Log("MoveToSpawnPointChild: MoveToSpawnPointMethod() started");

        GameObject spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");

        if (spawnPoint == null)
        {
            Debug.LogError("MoveToSpawnPointChild: SpawnPoint with tag 'SpawnPoint' not found in scene");
            return;
        }

        Debug.Log("MoveToSpawnPointChild: SpawnPoint found -> " + spawnPoint.name);

        Debug.Log("MoveToSpawnPointChild: SpawnPoint child count -> " + spawnPoint.transform.childCount);

        if (spawnPoint.transform.childCount < 2)
        {
            Debug.LogError("MoveToSpawnPointChild: SpawnPoint does not have a second child");
            return;
        }

        Transform targetPoint = spawnPoint.transform.GetChild(1);

        Debug.Log("MoveToSpawnPointChild: Target child selected -> " + targetPoint.name);
        Debug.Log("MoveToSpawnPointChild: Target position -> " + targetPoint.position);

        if (objectToMove == null)
        {
            Debug.LogError("MoveToSpawnPointChild: objectToMove not assigned in inspector");
            return;
        }

        Debug.Log("MoveToSpawnPointChild: objectToMove -> " + objectToMove.name);
        Debug.Log("MoveToSpawnPointChild: objectToMove current position -> " + objectToMove.transform.position);

        if (referencePoint == null)
        {
            Debug.LogError("MoveToSpawnPointChild: referencePoint not assigned in inspector");
            return;
        }

        Debug.Log("MoveToSpawnPointChild: referencePoint -> " + referencePoint.name);
        Debug.Log("MoveToSpawnPointChild: referencePoint position -> " + referencePoint.position);

        Vector3 delta = targetPoint.position - referencePoint.position;

        Debug.Log("MoveToSpawnPointChild: Calculated delta -> " + delta);

        objectToMove.transform.position += delta;

        Debug.Log("MoveToSpawnPointChild: New objectToMove position -> " + objectToMove.transform.position);

        objectToMove.transform.rotation = targetPoint.rotation;

        Debug.Log("MoveToSpawnPointChild: objectToMove rotation set to -> " + targetPoint.rotation);

        Debug.Log("MoveToSpawnPointChild: MoveToSpawnPointMethod() finished");
    }


    void MoveToSpawnPointMethod1()
    {
        Debug.Log("MoveToSpawnPointChild: MoveToSpawnPointMethod() started");

        GameObject spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");

        if (spawnPoint == null)
        {
            Debug.LogError("MoveToSpawnPointChild: SpawnPoint with tag 'SpawnPoint' not found in scene");
            return;
        }

        Debug.Log("MoveToSpawnPointChild: SpawnPoint found -> " + spawnPoint.name);

        Debug.Log("MoveToSpawnPointChild: SpawnPoint child count -> " + spawnPoint.transform.childCount);

        if (spawnPoint.transform.childCount < 2)
        {
            Debug.LogError("MoveToSpawnPointChild: SpawnPoint does not have a second child");
            return;
        }

        Transform targetPoint = spawnPoint.transform.GetChild(1);

        Debug.Log("MoveToSpawnPointChild: Target child selected -> " + targetPoint.name);
        Debug.Log("MoveToSpawnPointChild: Target position -> " + targetPoint.position);

        if (objectToMove == null)
        {
            Debug.LogError("MoveToSpawnPointChild: objectToMove not assigned in inspector");
            return;
        }

        Debug.Log("MoveToSpawnPointChild: objectToMove -> " + objectToMove.name);
        Debug.Log("MoveToSpawnPointChild: objectToMove current position -> " + objectToMove.transform.position);

        if (referencePoint == null)
        {
            Debug.LogError("MoveToSpawnPointChild: referencePoint not assigned in inspector");
            return;
        }

        Debug.Log("MoveToSpawnPointChild: referencePoint -> " + referencePoint.name);
        Debug.Log("MoveToSpawnPointChild: referencePoint position -> " + referencePoint.position);

        //Vector3 delta = targetPoint.position - referencePoint.position;

        //Debug.Log("MoveToSpawnPointChild: Calculated delta -> " + delta);

        objectToMove.transform.position = targetPoint.position;
        Debug.Log("MoveToSpawnPointChild: New objectToMove position -> " + objectToMove.transform.position);
        //objectToMove.transform.position = new Vector3(objectToMove.transform.position.x - 4,
        //                                            objectToMove.transform.position.y,
        //                                            objectToMove.transform.position.z -2);
        Debug.Log("MoveToSpawnPointChild: New objectToMove position -> " + objectToMove.transform.position);

        objectToMove.transform.rotation = targetPoint.rotation;
        //objectToMove.transform.rotation = new Quaternion(objectToMove.transform.rotation.x,
        //                                            objectToMove.transform.rotation.y+180,
        //                                            objectToMove.transform.rotation.z,
        //                                            objectToMove.transform.rotation.w);

        Debug.Log("MoveToSpawnPointChild: objectToMove rotation set to -> " + targetPoint.rotation);

        Debug.Log("MoveToSpawnPointChild: MoveToSpawnPointMethod() finished");
    }

    void MoveToSpawnPointMethod2()
    {
        Debug.Log("MoveToSpawnPointChild: MoveToSpawnPointMethod started");

        GameObject spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");

        if (spawnPoint == null)
        {
            Debug.LogError("MoveToSpawnPointChild: SpawnPoint not found");
            return;
        }

        Debug.Log("MoveToSpawnPointChild: SpawnPoint found -> " + spawnPoint.name);

        if (spawnPoint.transform.childCount < 2)
        {
            Debug.LogError("MoveToSpawnPointChild: SpawnPoint does not have second child");
            return;
        }

        Transform targetPoint = spawnPoint.transform.GetChild(1);

        Debug.Log("MoveToSpawnPointChild: Target child -> " + targetPoint.name);
        Debug.Log("MoveToSpawnPointChild: Target position -> " + targetPoint.position);

        if (objectToMove == null)
        {
            Debug.LogError("MoveToSpawnPointChild: objectToMove not assigned");
            return;
        }

        Debug.Log("MoveToSpawnPointChild: objectToMove -> " + objectToMove.name);

        // Move object pivot directly to target
        objectToMove.transform.position = targetPoint.position;

        Debug.Log("MoveToSpawnPointChild: object moved to -> " + objectToMove.transform.position);

        // Optional rotation
        objectToMove.transform.rotation = targetPoint.rotation;

        Debug.Log("MoveToSpawnPointChild: rotation set -> " + targetPoint.rotation);

        Debug.Log("MoveToSpawnPointChild: MoveToSpawnPointMethod finished");
    }

    void MoveToSpawnPointMethod3()
    {
        GameObject spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");

        if (spawnPoint == null)
        {
            Debug.LogError("MoveToSpawnPointChild: SpawnPoint not found");
            return;
        }

        if (spawnPoint.transform.childCount < 2)
        {
            Debug.LogError("MoveToSpawnPointChild: SpawnPoint does not have second child");
            return;
        }

        Transform targetPoint = spawnPoint.transform.GetChild(1);

        if (objectToMove == null || referencePoint == null)
        {
            Debug.LogError("MoveToSpawnPointChild: Missing objectToMove or referencePoint");
            return;
        }

        // Offset between pivot and reference point
        Vector3 offset = objectToMove.transform.position - referencePoint.position;

        // Move object so referencePoint matches target
        objectToMove.transform.position = targetPoint.position + offset;

        // Optional rotation
        objectToMove.transform.rotation = targetPoint.rotation;
    }


    private void Update()
    {
        Debug.Log("MoveToSpawnPointChild: activeSelf : "+ gameObject.activeSelf);
        Debug.Log("MoveToSpawnPointChild: position   : " + gameObject.transform.position);
    }


}





