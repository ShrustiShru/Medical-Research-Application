using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    class Symptoms
    {
        public string DiseaseName { get; set; }
        public string SymptomName { get; set; }
    }

    class SymptomsManager
    {
        ArrayList Symptoms = new ArrayList();
        public void AddSymptoms(Symptoms ss)
        {
            Symptoms.Add(ss);
            return;
        }
    }
}
