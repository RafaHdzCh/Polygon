using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{
    public Person father;
    public Person mother;
    public Person son;

    void Start()
    {
        father = new Person("Anakin", "Skywalker", 35, true);

        mother = new Person();
        mother.firstName = "Padme";
        mother.lastName = "Amidala";
        mother.age = 40;
        mother.isMale = false;

        father.spouse = mother;
        mother.spouse = father;

        son = new Person();
        son.firstName = "Luke";
        son.lastName = "Skywalker";
        son.age = 8;
        son.isMale = true;

        Debug.Log(father.firstName + " y " + mother.firstName + " tienen un hijo llamado " + son.firstName);

      	if (father.isMarriedWith(mother))
      	{
      		Debug.Log(father.firstName + " y " + mother.firstName + " estan casados.");
      	}
      	else 
      	{
      		Debug.Log(father.firstName + " y " + mother.firstName + " no estan casados.");
      	}
    }

    
    void Update()
    {
        
    }
}
