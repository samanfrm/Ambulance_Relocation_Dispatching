using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ambulance_Relocation_Dispatching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<state> statelist = new List<state>();
        private void btn_search_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            txt_path.Text = "";        
            state initial = initialstate();
            statelist.Add(initialstate());
            int maxQ = 1;
            int TimeComplex = 0;
            while (statelist.Count != 0)
            {

                statelist = statelist.OrderBy(o => o.sumRT).ToList();
                state current;
                current = statelist[0];
                TimeComplex += 1;
                if (current.services.Count == 0)
                {
                    float meanRStime = float.Parse((current.sumRT).ToString()) / 5;
                    txt_path.Text += current.path.Replace(",", "\r\n");
                    txt_path.Text +="\r\n--------------------\r\n Mean Response Time:" + meanRStime.ToString() + "s";
                    txt_path.Text += "\r\n Time Complexity:" + TimeComplex.ToString();
                    txt_path.Text += "\r\nMax Q Size:" + maxQ.ToString();
                    break;
                }
                else
                {
                    A0child(current);//create childs A0 dispatch to remaining's calls and insert into queue
                    A1child(current);//create childs A1 dispatch to remaining's calls and insert into queue
                    A2child(current);//create childs A2 dispatch to remaining's calls and insert into queue
                    if (statelist.Count > maxQ)
                        maxQ = statelist.Count;           
                }
                statelist.Remove(current);//remove expanded node from queue
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            txt_path.Text += "\r\n Running Time:" + ts.TotalSeconds + "s";


            }
        //****************************************************
        private void A0child(state father)//create A0 child and return
        {
            foreach (point call in father.services)
            {
                int sumA0 = father.sumA0;
                if (sumA0 != 0)
                    sumA0 += 2;
                sumA0 += Math.Abs(father.ambulances[0].x - call.x);
                sumA0 += Math.Abs(father.ambulances[0].y - call.y);
                int sumRT = father.sumRT + sumA0;
                state A0 = new state(father.path + ",A0->" + call.name, sumRT, sumA0, father.sumA1, father.sumA2);
                for (int i = 0; i < 3; i++)
                {
                    A0.ambulances[i].x = father.ambulances[i].x;
                    A0.ambulances[i].y = father.ambulances[i].y;
                    A0.ambulances[i].name = father.ambulances[i].name;
                }
                A0.ambulances[0].x = call.x;
                A0.ambulances[0].y = call.y;

                foreach (point service in father.services)
                {
                    A0.services.Add(service);
                }
                A0.services.Remove(call);
                statelist.Add(A0);
            }
                     
        }
        //*******************************************************
        private void A1child(state father)//create A1 child and return
        {
            foreach (point call in father.services)
            {
                int sumA1 = father.sumA1;
                if (sumA1 != 0)
                    sumA1 += 2;
                sumA1 += Math.Abs(father.ambulances[1].x - call.x);
                sumA1 += Math.Abs(father.ambulances[1].y - call.y);
                int sumRT = father.sumRT + sumA1;
                state A1 = new state(father.path + ",A1->" + call.name, sumRT, father.sumA0, sumA1, father.sumA2);
                for (int i = 0; i < 3; i++)
                {
                    A1.ambulances[i].x = father.ambulances[i].x;
                    A1.ambulances[i].y = father.ambulances[i].y;
                    A1.ambulances[i].name = father.ambulances[i].name;
                }
                A1.ambulances[1].x = call.x;
                A1.ambulances[1].y = call.y;

                foreach (point service in father.services)
                {
                    A1.services.Add(service);
                }
                A1.services.Remove(call);
                statelist.Add(A1);
            }
        }

        //*******************************************************
        private void A2child(state father)//create A2 child and return
        {
            foreach (point call in father.services)
            {
                int sumA2 = father.sumA2;
                if (sumA2 != 0)
                    sumA2 += 2;
                sumA2 += Math.Abs(father.ambulances[2].x - call.x);
                sumA2 += Math.Abs(father.ambulances[2].y - call.y);
                int sumRT = father.sumRT + sumA2;
                state A2 = new state(father.path + ",A2->" + call.name, sumRT, father.sumA0, father.sumA1, sumA2);
                for (int i = 0; i < 3; i++)
                {
                    A2.ambulances[i].x = father.ambulances[i].x;
                    A2.ambulances[i].y = father.ambulances[i].y;
                    A2.ambulances[i].name = father.ambulances[i].name;
                }
                A2.ambulances[2].x = call.x;
                A2.ambulances[2].y = call.y;

                foreach (point service in father.services)
                {
                    A2.services.Add(service);
                }
                A2.services.Remove(call);
                statelist.Add(A2);
            }
        }
        //*********************************************************************************
        private state initialstate()//return initial state
        {
            state initial = new state("", 0,0,0,0);
            string[] ambx = txt_ambx.Text.Split(',');
            string[] amby = txt_amby.Text.Split(',');
            string[] servx = txt_srvx.Text.Split(',');
            string[] servy = txt_srvy.Text.Split(',');
            for (int i = 0; i < 3; i++)
            {
                initial.ambulances[i].x = int.Parse(ambx[i]);
                initial.ambulances[i].y = int.Parse(amby[i]);
                initial.ambulances[i].name = "A" + i;
            }
            for (int i = 0; i < 5; i++)
            {
                point serv = new point();
                serv.x = int.Parse(servx[i]);
                serv.y = int.Parse(servy[i]);
                serv.name = "C" + i;
                initial.services.Add(serv);
            }
            return initial;

        }
        //--------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------
        //--------------------------------------------------------//random 10 functions-------------------------------------------
        //*****************************************
        private void btn_rand1run_Click(object sender, EventArgs e)//10 random services
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            txt_rand1path.Text = "";
            statelist.Clear();
            state initial = rand1initialstate();
            statelist.Add(rand1initialstate());
            int maxQ = 1;
            int TimeComplex = 0;
            while (statelist.Count != 0)
            {

                statelist = statelist.OrderBy(o => o.sumRT).ToList();
                state current;
                current = statelist[0];
                TimeComplex += 1;
                if (current.services.Count == 0)
                {
                    float meanRStime = float.Parse((current.sumRT).ToString()) / 10;
                    txt_rand1path.Text += current.path.Replace(",", "\r\n");
                    txt_rand1path.Text += "\r\n--------------------\r\n Mean Response Time:" + meanRStime.ToString() + "s";
                    txt_rand1path.Text += "\r\n Time Complexity:" + TimeComplex.ToString();
                    txt_rand1path.Text += "\r\nMax Q Size:" + maxQ.ToString();
                    break;
                }
                else
                {
                    A0child(current);//create childs A0 dispatch to remaining's calls and insert into queue
                    A1child(current);//create childs A1 dispatch to remaining's calls and insert into queue
                    A2child(current);//create childs A2 dispatch to remaining's calls and insert into queue
                    if (statelist.Count > maxQ)
                        maxQ = statelist.Count;   
                }
                statelist.Remove(current);//remove expanded node from queue
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            txt_rand1path.Text += "\r\n Running Time:" + ts.TotalMilliseconds + "ms";
            }
        //******************************************************************
        private state rand1initialstate()//return initial state for random 10 services
        {
            state initial = new state("", 0, 0, 0, 0);
            string[] ambx = txt_rand1ambx.Text.Split(',');
            string[] amby = txt_rand1amby.Text.Split(',');
            int[] servx = new int[10];
            int[] servy = new int[10];
            Random randobj = new Random();
            for (int i = 0; i < 10; i++)
            {
                servx[i] = randobj.Next(0, 99);
                txt_ran1SVx.Text += servx[i].ToString() + ',';
                servy[i] = randobj.Next(0, 99);
                txt_ran1SVy.Text += servy[i].ToString() + ',';
            }
            for (int i = 0; i < 3; i++)
            {
                initial.ambulances[i].x = int.Parse(ambx[i]);
                initial.ambulances[i].y = int.Parse(amby[i]);
                initial.ambulances[i].name = "A" + i;
            }
            for (int i = 0; i < 10; i++)
            {
                point serv = new point();
                serv.x = servx[i];
                serv.y = servy[i];
                serv.name = "C" + i;
                initial.services.Add(serv);
            }
            return initial;
        }
        //-----------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------
        //--------------------------------------------------------//random 100 functions-------------------------------------------
        //*****************************************************************
        private void btn_rand2run_Click(object sender, EventArgs e)//100 random services
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            txt_rand2path.Text = "";
            statelist.Clear();
            state initial = rand2initialstate();
            statelist.Add(rand2initialstate());
            int maxQ = 1;
            int TimeComplex = 0;
            while (statelist.Count != 0)
            {

                statelist = statelist.OrderBy(o => o.sumRT).ToList();
                state current;
                current = statelist[0];
                TimeComplex += 1;
                if (current.services.Count == 0)
                {
                    float meanRStime = float.Parse((current.sumRT).ToString()) / 100;
                    txt_rand2path.Text += current.path.Replace(",", "\r\n");
                    txt_rand2path.Text += "\r\n--------------------\r\n Mean Response Time:" + meanRStime.ToString() + "s";
                    txt_rand2path.Text += "\r\n Time Complexity:" + TimeComplex.ToString();
                    txt_rand2path.Text += "\r\nMax Q Size:" + maxQ.ToString();
                    break;
                }
                else
                {
                    A0child(current);//create childs A0 dispatch to remaining's calls and insert into queue
                    A1child(current);//create childs A1 dispatch to remaining's calls and insert into queue
                    A2child(current);//create childs A2 dispatch to remaining's calls and insert into queue
                    if (statelist.Count > maxQ)
                        maxQ = statelist.Count;   
                }
                statelist.Remove(current);//remove expanded node from queue
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            txt_rand2path.Text += "\r\n Running Time:" + ts.TotalMilliseconds + "ms";
        }

        //******************************************************************************
        private state rand2initialstate()//return initial 100 random services
        {
            state initial = new state("", 0,0,0,0);
            string[] ambx = txt_rand2ambx.Text.Split(',');
            string[] amby = txt_rand2amby.Text.Split(',');
            int[] servx = new int[100];
            int[] servy = new int[100];
            Random randobj = new Random();
            for (int i = 0; i < 100; i++)
            {
                servx[i] = randobj.Next(0, 99);
                txt_ran2svx.Text += servx[i].ToString() + ',';
                servy[i] = randobj.Next(0, 99);
                txt_ran2svy.Text += servy[i].ToString() + ',';
            }
            for (int i = 0; i < 3; i++)
            {
                initial.ambulances[i].x = int.Parse(ambx[i]);
                initial.ambulances[i].y = int.Parse(amby[i]);
                initial.ambulances[i].name = "A" + i;
            }
            for (int i = 0; i < 100; i++)
            {
                point serv = new point();
                serv.x = servx[i];
                serv.y = servy[i];
                serv.name = "C" + i;
                initial.services.Add(serv);
            }
            return initial;
        }



    }
}
