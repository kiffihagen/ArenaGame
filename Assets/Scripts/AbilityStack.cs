using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AbilityStack : MonoBehaviour {

    private List<BaseAbility> _abilities = new List<BaseAbility>();

    private int _abilityCycleIndex = 0;

    public float TimeBetweenAbilityCycling = 1f;

    private float _timeOfLastAbilityCycling = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time >= _timeOfLastAbilityCycling + TimeBetweenAbilityCycling)
	    {
	        CycleAbilities();
	    }
	}

    private void CycleAbilities()
    {
        _timeOfLastAbilityCycling = Time.time;
        _abilityCycleIndex = (_abilityCycleIndex + 1) % _abilities.Count;
    }

    public void UseAbility()
    {
        _abilities[_abilityCycleIndex].Use();
    }

    public void AddAbility(BaseAbility ability)
    {
        _abilities.Add(ability);
    }
}
