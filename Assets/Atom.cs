using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom : MonoBehaviour {

    private List<int> electronShells = new List<int>();

    public string electronsPerShell;
    public string atom;
    public GameObject protonPrefab;
    public GameObject electronPrefab;

	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = atom + "\n" + electronsPerShell;
        if (electronsPerShell != null)
        {

            string[] eps = electronsPerShell.Split(',');
            electronShells.Clear();
            foreach (string e in eps)
            {
                electronShells.Add(int.Parse(e));
            }
            // First make the nucleus
            GameObject proton = GameObject.Instantiate(protonPrefab);
            proton.transform.parent = this.transform;
            proton.transform.position = transform.position;
            
            float gap = 15.0f;
            for (int ring = 0 ; ring < electronShells.Count; ring ++)
            {
                int electrons = electronShells[ring];
                float theta = (Mathf.PI * 2.0f) / electrons;
                for (int i = 0; i < electrons ; i++)
                {
                    Vector3 pos = new Vector3();
                    float radius = (ring + 1) * gap;
                    pos.x = transform.position.x
                        + (Mathf.Sin(theta * i) * radius);
                    pos.y = transform.position.y;
                    pos.z = transform.position.z
                        + (Mathf.Cos(theta * i) * radius);

                    GameObject electron = GameObject.Instantiate(electronPrefab);
                    electron.transform.parent = this.transform;
                    electron.transform.position = pos;
                    electron.transform.rotation = Quaternion.AngleAxis(
                        Mathf.Rad2Deg * theta, Vector3.up);
                    electron.GetComponent<Orbit>().center = proton;
                    electron.GetComponent<Boid>().maxSpeed += (ring * 3);
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
