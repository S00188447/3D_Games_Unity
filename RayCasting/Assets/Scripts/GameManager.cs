using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public List<WorldResource> possibleResources;
    Dictionary<ResourceTypes, int> registeredGenerators = new Dictionary<ResourceTypes, int>();
    Dictionary<ResourceTypes, int> generatedResources = new Dictionary<ResourceTypes, int>();

    public GameObject GeneratedPrefab;

    void Start()
    {
        registeredGenerators.Add(ResourceTypes.Coal, 0);
        registeredGenerators.Add(ResourceTypes.Water, 0);
        registeredGenerators.Add(ResourceTypes.Solid, 0);
        registeredGenerators.Add(ResourceTypes.Gold, 0);

        generatedResources.Add(ResourceTypes.Coal, 0);
        generatedResources.Add(ResourceTypes.Water, 0);
        generatedResources.Add(ResourceTypes.Solid, 0);
        generatedResources.Add(ResourceTypes.Gold, 0);

        Invoke("Generate Resources", 2);
    }

    public void SpawnGenerator(Vector3 location, Vector3 normal, Color resourceColor)
    {

        //any returns a bool
        if(possibleResources.Any(wr=> wr.ResourceColor == resourceColor))
        {
            ResourceTypes type = possibleResources.Find(wr => wr.ResourceColor == resourceColor).Type;

            GameObject generator = Instantiate(GeneratedPrefab, location, Quaternion.identity);
            generator.transform.up = normal;

            ResourceGenerator res = generator.GetComponent<ResourceGenerator>();
            res.setMaterialColor(resourceColor);

            registeredGenerators[type]++;
        }

        void GenerateResources()
        {
            generatedResources[ResourceTypes.Coal] += registeredGenerators[ResourceTypes.Coal];
            generatedResources[ResourceTypes.Solid] += registeredGenerators[ResourceTypes.Solid];
            generatedResources[ResourceTypes.Water] += registeredGenerators[ResourceTypes.Water];
            generatedResources[ResourceTypes.Gold] += registeredGenerators[ResourceTypes.Gold];

            //Debug.Log("Coal: " + generatedResources[ResourceTypes.Coal]);
            //Debug.Log("Gold: " + generatedResources[ResourceTypes.Gold]);
            //Debug.Log("Water: " + generatedResources[ResourceTypes.Water]);
            //Debug.Log("Soil: " + generatedResources[ResourceTypes.Solid]);

            Invoke("Generate Resources",2);
        }

   
    }
}
