using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int coinAmount = 100;

    public void ConsumeCoin()
    {
        if (coinAmount > 0)
        {
            coinAmount--;
        }
    }

    public void AddCoin(int amount)
    {
        coinAmount += amount;
    }

    public int GetCoinAmount()
    {
        return coinAmount;
    }
}
