using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {

    // You can make a list of gameObjects
    public GameObject prefab; // 0 Dimensional (1 prefab / 1 object) 
    public GameObject[] prefabList; // 1 Dimensional (List of prefabs) Useful for making blocks change or switch costumes like in Scratch ;)
    

    
    
	void Start () {
        // Instantiate(1,2,3); Creates clones / gameObjects

        // 1 can be a prefab or prefabList. Choose costume by doing prefabList[#] <<<

        // Look at the options for the prefabs/costumes in the inspector
        // In C# values go towards 0 so the first option is going to be prefabList[0]

        // 2 can be transform.position or vector3 variable or transform variable or vector2 variable.

        // Transform transformVar;
        // Vector3 Vector3var;
        // Vector2 Vector2var;

        // 3 can be Quaternion.identity or any rotation value

        Instantiate(prefab, transform.position, Quaternion.identity);

        // or

        Instantiate(prefabList[0], transform.position, Quaternion.identity);

        // We can also assign a position to our clone like this.
        Vector3 position;
        position = new Vector3(0,0,0);
        Instantiate(prefabList[0], position, Quaternion.identity);

        // Destroy(1); Destroys game objects by a type of prefab.
        // 1 can be prefab or prefabList[#]

        Destroy(prefab);

        //or

        Destroy(prefabList[0]);

        //this will destroy all objects using that prefab.

        // Ok now lets assign our objects so we can destroy a prefab we assign.
        // This will be really helpful if you want to destroy something specific.
        

        // Im going to make a list we can use to store our clones in.
        GameObject[] clones = new GameObject[9 /*Length of the list put whatever value you want here.*/];

        // Here's how you can create a clone/gameObject and assign it.
        clones[1 /*Put whatever value you want here */] = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;

        // Now let's destroy the object.
        Destroy(clones[1]);

        // Let's do something with this
        // Let's create a bunch of clones
        for (int i = 0; i <= 9; i++)
        {
            clones[i] = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
        }

        // Let's destroy one of them
        Destroy(clones[5]);




        // You can see how this can be helpful in big projects. Especially map generation. 
        // If we wanted to go further we could make a 2Darray or spreadsheet of gameObjects

        
        GameObject[,] cloneArray = new GameObject[10,10];
        int[,] map = new int[10, 10];

        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                map[x, y] = 0;
                position = new Vector3(x, y, 0);
                cloneArray[x, y] = Instantiate(prefabList[map[x, y]], position, Quaternion.identity) as GameObject;

            }
        }

        // Clones are better in Unity and C# than in Scratch. LOL XD

        // Also the objects probably got spawned and destroyed really fast but you have access to the functions! :)


    }
	
	
}
