using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject goldCoinPrefab, silverCoinPrefab, copperCoinPrefab;
    public CoinManager coinManager;
    public float shotForce, shotTorque;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
    }

    GameObject SampleCandy()
    {
        int index = Random.Range(0, 100);

        if (index == 0)
        {
            return goldCoinPrefab;
        }
        else if (index == 1 || index == 2)
        {
            return silverCoinPrefab;
        }
        else
        {
            return copperCoinPrefab;
        }
    }

    public void Shot()
    {
        if (coinManager.GetCoinAmount() >= 1)
        {
            GameObject coin = Instantiate(SampleCandy(), transform.position, Quaternion.identity);
            Rigidbody coinRigidBody = coin.GetComponent<Rigidbody>();
            coinRigidBody.AddForce(transform.forward * shotForce);
            coinRigidBody.AddTorque(new Vector3(0, shotTorque, 0));
            coinManager.ConsumeCoin();
        }
    }
}
