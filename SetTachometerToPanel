using MSCLoader;
using UnityEngine;
using System;
using System.Threading;

namespace SetTachometerToPanel
{
    public class SetTachometerToPanel : Mod
    {
        public override string ID { get { return "SetTachometerToPanel"; } }
        public override string Name { get { return "SetTachometerToPanel"; } }
        public override string Author { get { return "vWernayBR"; } }
        public override string Version { get { return "1.0"; } }

        public override bool UseAssetsFolder => false;

        private GameObject SATSUMA;

        private GameObject COLUMN;

        private GameObject DASHBOARD;

        private GameObject TACHOMETER;

        private GameObject TRIGGERTACHOMETER;

        private GameObject DASHBOARDPIVOT;

        private GameObject DASHBOARCLONE;

        private GameObject EXTRAGAUGES;

        private GameObject TRIGGEREXTRAGAUGES;

        private GameObject STEERING;

        public override void OnLoad()
        {
            new Thread(waiting).Start();
        }

        private void waiting()
        {
            Thread.Sleep(10 * 1000);

            this.SATSUMA = GameObject.Find("SATSUMA(557kg, 248)");
            this.DASHBOARD = this.SATSUMA.transform.FindChild("Dashboard").gameObject;
            this.STEERING = this.DASHBOARD.transform.FindChild("Steering").gameObject;
            this.COLUMN = this.STEERING.transform.FindChild("steering_column2").gameObject;
            this.TACHOMETER = this.COLUMN.transform.FindChild("tachometer(xxxxx)").gameObject;
            this.TRIGGERTACHOMETER = this.COLUMN.transform.FindChild("trigger_tachometer").gameObject;
            this.DASHBOARDPIVOT = this.DASHBOARD.transform.FindChild("pivot_dashboard").gameObject;
            this.DASHBOARCLONE = this.DASHBOARDPIVOT.transform.FindChild("dashboard(Clone)").gameObject;
            this.EXTRAGAUGES = this.DASHBOARCLONE.transform.FindChild("extra gauges(xxxxx)").gameObject;
            this.TRIGGEREXTRAGAUGES = this.DASHBOARCLONE.transform.FindChild("trigger_extra_gauges").gameObject;
            if (DASHBOARCLONE)
            {
                this.TACHOMETER.transform.localPosition = new Vector3(-0.10f, -0.27f, 0.27f);
                this.TRIGGERTACHOMETER.transform.localPosition = new Vector3(-0.10f, -0.27f, 0.27f);
                this.EXTRAGAUGES.transform.localPosition = new Vector3(-0.021f, -0.01f, 0.15f);
                this.TRIGGEREXTRAGAUGES.transform.localPosition = new Vector3 (-0.021f, -0.01f, 0.15f);
            }
        }
    }
}
