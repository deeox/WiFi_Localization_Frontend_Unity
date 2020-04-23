using UnityEngine;
using System.Collections;

public class ExampleGeoJSONLoader : MonoBehaviour {

	public TextAsset encodedGeoJSON;

	public GeoJSON.FeatureCollection collection;

	// Use this for initialization
	void Start () {
        collection = GeoJSON.GeoJSONObject.Deserialize (encodedGeoJSON.text);
	}

}
