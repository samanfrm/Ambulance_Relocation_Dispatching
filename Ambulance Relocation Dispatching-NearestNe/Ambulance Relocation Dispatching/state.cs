using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ambulance_Relocation_Dispatching
{
    struct point
    {
        public int x;
        public int y;
        public string name;//name of ambulance or services ex: A0...
    }

    class state
    {
        public point[] ambulances = new point[3];
        public List<point> services;
        public state(string path2,int sumRT2,int sumA01,int sumA11,int sumA21)
        {
            services = new List<point>();
            path = path2;
            sumRT = sumRT2;
            sumA0 = sumA01;
            sumA1 = sumA11;
            sumA2 = sumA21;
        }
        public string path;
        public int sumRT;//for calculate sum of response times
        public int sumA0;//for calculate sum of response times
        public int sumA1;//for calculate sum of response times
        public int sumA2;//for calculate sum of response times
        
        
    }
}
