using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    class DiseaseDetails
    {
        public string DiseaseName { get; set; }
        enum Cause { ExternalFactors, InternalDisorder };
        public string DiseaseSeverity { get; set; }
        public string Description { get; set; }
    }

    class DiseaseManager
    {
        ArrayList Disease =new ArrayList();

        public void AddDisease(DiseaseDetails dd)
        {
            Disease.Add(dd);
            return;
        }
    }

    
    class Disease
    {
        static void Main(string[] args)
        {
            
        }
    }
}
