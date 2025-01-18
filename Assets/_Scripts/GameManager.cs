using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public event EventHandler<OnClickdOnGridPositionEventArgs> OnClickedOnGridPosition;
    public class OnClickdOnGridPositionEventArgs : EventArgs
    {
        public int x;
        public int y;
    }

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log("There are multiple GameManager instance");
        }
        Instance = this;
    }
    public void ClickedOnGridPosition(int x, int y)
    {
        Debug.Log("ClickedOnGridPoisition: " + x + ", " + y);
        OnClickedOnGridPosition?.Invoke(this, new OnClickdOnGridPositionEventArgs {
            x = x,
            y = y,
        });
    }
}
