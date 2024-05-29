using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;

namespace GetBoltLength
{
    public partial class Form_bolt : Form
    {
        Model _model;
        DataGridView dataGridView2;

        public Form_bolt()
        {

            InitializeComponent();


            dataGridView2 = new DataGridView();

            _model = new Model();
        }

        private void Form_bolt_Load(object sender, EventArgs e)
        {

            try

            {

                if (_model.GetConnectionStatus())
                {

                    Operation.DisplayPrompt("App is now connected to Tekla Structures");


                }
                else
                {
                    MessageBox.Show("Something went wrong !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void bolts_btn_Click(object sender, EventArgs e)
        {

            BoltsReportProperties boltsReportProperties = new BoltsReportProperties();
            var data = boltsReportProperties.Run();




            dataGridView1.Columns.Add("Bolts", "Bolts");

            foreach (var d in data)
            {
                dataGridView1.Rows.Add(d);
            }

        }


    }



    public class BoltsReportProperties
    {
        
        private readonly ArrayList _reportProperties = new ArrayList { "SCREW_NAME", "SCREW_TYPE" };
        public ArrayList Run()
        {

            Model _model = new Model();
            ModelObjectEnumerator modelObjectEnum = _model.GetModelObjectSelector().GetAllObjects();


            var bolts = modelObjectEnum.ToList();


            var boltsProperties = bolts.OfType<BoltArray>().Select(b =>
            {
                var properties = new Hashtable();
                b.GetStringReportProperties(_reportProperties, ref properties);

                return new
                {
                    bolt = b,
                    StringProps = properties,
                };
            }).ToList();

            var json = JsonConvert.SerializeObject(boltsProperties);
            //test
            Console.WriteLine(json);

            var boltsNames = new ArrayList();

            foreach (var entry in boltsProperties)

            {
                string boltN = entry.StringProps["SCREW_NAME"].ToString();
                boltsNames.Add(boltN);


            }



            return boltsNames;
        }




    }


    public static class TeklaExxtensions
    {

        public static IList<ModelObject> ToList(this ModelObjectEnumerator enumerator)
        {
            var listObjects = new List<ModelObject>();
            while (enumerator.MoveNext())
            {
                var obj = enumerator.Current;
                if (obj == null) continue;

                listObjects.Add(obj);
            }
            return listObjects;
        }
    }

}
