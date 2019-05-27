using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickup : MonoBehaviour
{

    public PickUp pickupPrefab;
    public Traktor traktorPrefab;
    public GameObject cowParent;
    public GameObject traktorParent;
    private void SpawnCow()
    {
        float cowSize = 0.5f;
        PickUp cowClone = (PickUp)Instantiate(pickupPrefab, transform.position, transform.rotation);
        cowClone.transform.SetParent(cowParent.transform);
        cowClone.transform.localPosition = new Vector3(Random.Range(-6f, 6f), cowParent.transform.position.y, 0f);
        cowClone.transform.localScale = new Vector3(cowSize, cowSize, 0);
        cowClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-7, -3));
    }
    private void SpawnTraktor()
    {
        float traktorSize = 0.05f;
        Traktor traktorClone = (Traktor)Instantiate(traktorPrefab, transform.position, transform.rotation);
        traktorClone.transform.SetParent(traktorParent.transform);
        traktorClone.transform.localPosition = new Vector3(Random.Range(-6f, 6f), traktorParent.transform.position.y, 0f);
        traktorClone.transform.localScale = new Vector3(traktorSize, traktorSize, 0);
        traktorClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-7, -3));
    }
    private void Update()
    {
        // SpawnCow();
        // SpawnTraktor();
    }
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnCow();
            SpawnTraktor();
        }

    }

}
