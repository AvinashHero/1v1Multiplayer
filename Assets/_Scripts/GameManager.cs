using System;
using Unity.Netcode;
using UnityEngine;

public class GameManager : NetworkBehaviour
{
    public static GameManager Instance { get; private set; }

    public event EventHandler<OnClickdOnGridPositionEventArgs> OnClickedOnGridPosition;
    public class OnClickdOnGridPositionEventArgs : EventArgs
    {
        public int x;
        public int y;
        public PlayerType playerType;
    }

    public enum PlayerType
    {
        None,
        Cross,
        Circle,
    }

    private PlayerType localPlayerType;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log("There are multiple GameManager instance");
        }
        Instance = this;
    }

    public override void OnNetworkSpawn()
    {
        if(NetworkManager.Singleton.LocalClientId == 0)
        {
            localPlayerType = PlayerType.Cross;
        } else
        {
            localPlayerType = PlayerType.Circle;
        }
    }
    public void ClickedOnGridPosition(int x, int y)
    {
        Debug.Log("ClickedOnGridPoisition: " + x + ", " + y);
        OnClickedOnGridPosition?.Invoke(this, new OnClickdOnGridPositionEventArgs {
            x = x,
            y = y,
            playerType = GetLocalPlayerType(),
        });
    }

    public PlayerType GetLocalPlayerType()
    {
        return localPlayerType;
    }
}
