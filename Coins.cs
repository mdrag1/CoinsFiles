using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;

    private void Awake()
    {
        KeepCoins.StartCoins(PlayerPrefs.GetInt("Coins", 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            KeepCoins.OnPickupCoin();
            PickuCoinsPresentpCoin(CoinsReturn);
    }

    private void TryDiscard(int _price){
        if(!KeepCoins.TryDiscard(_price)){
            Debug.Log("You don't have enough coins!")
        }
        CoinsPresent(CoinsReturn);
    }

    private void CoinsPresent(amount){
        _render.text = $"Coins: {amount}";
        _animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", amount);
    }
}
