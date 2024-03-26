using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawner : MonoBehaviour
{
    public Transform itemBoxSpawnPoint;
    public GameObject itemBoxPrefab;
    public GameObject itemBoxPrefabCopy;

    private void Start()
    {
        itemBoxPrefabCopy = Instantiate(itemBoxPrefab, itemBoxSpawnPoint.transform);
    }

    public void SpawnItemBox()
    {
        itemBoxPrefabCopy = Instantiate(itemBoxPrefab, itemBoxSpawnPoint.transform);
    }

    public void StartItemBoxCoroutine()
    {
        StartCoroutine(SpawnAndRespawn());
    }

    IEnumerator SpawnAndRespawn()
    {
        Destroy(itemBoxPrefabCopy);
        yield return new WaitForSeconds(5);

        SpawnItemBox();
        yield return null;
    }

}
