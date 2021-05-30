using MSCLoader;
using System;
using System.Threading;
using UnityEngine;

namespace RIMR18INCH
{
    public class RIMR18INCH : Mod
    {
        public override string ID { get { return "RIMR18INCH"; } }
        public override string Name { get { return "RIMR18INCH"; } }
        public override string Author { get { return "vWernayBR"; } }
        public override string Version { get { return "1.0"; } }

        private GameObject FLRIM;

        private GameObject FRRIM;

        private GameObject RLRIM;

        private GameObject RRRIM;

        public override bool UseAssetsFolder
        {
            get
            {
                return true;
            }
        }

        public override void OnLoad()
        {
            new Thread(new ThreadStart(this.Waiting2r)).Start();
        }

        private void Waiting2r()
        {
            Thread.Sleep(20000);
            Mesh mesh = LoadAssets.LoadOBJMesh(this, "tire_rally.obj");
            Texture2D mainTexture = LoadAssets.LoadTexture(this, "tires_rally.dds", false);
            GameObject[] array = GameObject.FindObjectsOfType<GameObject>();
            for (int i = 0; i < array.Length; i++)
            {
                GameObject gameObject = array[i];
                if (gameObject.name == "TireRally(Clone)")
                {
                    gameObject.GetComponent<MeshFilter>().mesh = (mesh);
                    gameObject.GetComponent<MeshRenderer>().material.mainTexture = (mainTexture);
                }
            }
            if (GameObject.Find("wheel rally fl(Clone)").activeSelf)
            {

                this.FLRIM = GameObject.Find("wheel rally fl(Clone)");
                this.FRRIM = GameObject.Find("wheel rally fr(Clone)");
                this.RLRIM = GameObject.Find("wheel rally rl(Clone)");
                this.RRRIM = GameObject.Find("wheel rally rr(Clone)");
                Mesh mesh2 = LoadAssets.LoadOBJMesh(this, "rim_rally.obj");
                this.FLRIM.transform.GetComponent<MeshFilter>().mesh = (mesh2);
                this.FRRIM.transform.GetComponent<MeshFilter>().mesh = (mesh2);
                this.RLRIM.transform.GetComponent<MeshFilter>().mesh = (mesh2);
                this.RRRIM.transform.GetComponent<MeshFilter>().mesh = (mesh2);
            }
        }
    }
}       
