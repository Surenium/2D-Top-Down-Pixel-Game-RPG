using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    //Resources

    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;


    // References

    public Player player;
    // public weapon....

    //Logic
    public int Gems;

    public void SaveState()
    {

    }

    public void LoadState()
    {

    }
}
