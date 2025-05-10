using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinWallet : MonoBehaviour
{
    public int TotalCoins { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.TryGetComponent<Coin>(out Coin coin)) { return; }

        int coinValue = coin.Collect();

        TotalCoins += coinValue;
    }
}
