using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
	Hero,
	Solider,
	Builder
}

public class UnitData
{
	public static int StaticYY;
	public int uid;
	public UnitType unitType;

	public UnitType UType
	{
		get;set;
	}
}

public class Unit : MonoBehaviour {

	public static int StaticID;
	public int myAge;
	public UnitData unitData;

	public int MyAge
	{
		get;set;
	}

	public UnitData MyUnitData
	{
		get;set;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
