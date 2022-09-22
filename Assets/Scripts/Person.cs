using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    public string firstName;
    public string lastName;
    public int age;
    public bool isMale;
    public Person spouse;

    //Constructor por defecto
    public Person() 
    {

    }

    public Person(string pFirstName, string pLastName, int pAge, bool pIsMale)
    {
    	this.firstName = pFirstName;
    	this.lastName = pLastName;
    	this.age = pAge;
    	this.isMale = pIsMale;
    }

    public bool isMarriedWith(Person otherPerson)
    {
    	if(this.spouse == null)
    	{
    		Debug.Log("No esta casado.");
    		return false;
    	}
    	else
    	{
    		Debug.Log("Esta casado.");
    		if(otherPerson.firstName == this.spouse.firstName &&
    		   otherPerson.lastName == this.spouse.lastName)
    		{
    			Debug.Log("Esta casado con la otra persona.");
    			return true;
    		}
    		else
    		{
    			Debug.Log("Esta casado pero no con la otra persona.");
    			return false;
    		}
    	}
    }

    public void setFirstname(string firstName)
    {
        //this.firstName = firstName;
    }
}
