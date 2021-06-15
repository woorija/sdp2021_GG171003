using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eObserverEvent
{
	Life,
	Score
}

public abstract class Observer : MonoBehaviour
{
	public abstract void OnNotify(eObserverEvent observerEvent, int value);
}

