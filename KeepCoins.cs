

private class KeepCoins : Coins
{
    int _amount = -2;

    //
    void StartCoins(_count){
        if _amount == -2{
            _amount = _count;}
    }

    void OnPickupCoin()
    {
        _amount++;
    }

    bool TryDiscard(int price)
    {
        if (_amount < price)
            return false;

        _amount -= price;

        return true;
    }

    int CoinsReturn(){
        return _amount;
    }
}