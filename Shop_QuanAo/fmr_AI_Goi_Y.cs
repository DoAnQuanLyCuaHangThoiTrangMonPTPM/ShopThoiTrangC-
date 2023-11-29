using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DAL;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using Accord.MachineLearning;
using Accord.Math;
using Accord;


namespace Shop_QuanAo
{
    public partial class fmr_AI_Goi_Y : Form
    {
        DBConnect dbconn = new DBConnect();
        public fmr_AI_Goi_Y()
        {
            InitializeComponent();
        }
        public DataTable loadData_AI()
        {
            DataTable dt_kh = new DataTable();
            string sqlselect = "SELECT * FROM `ai_table`";
            dt_kh = dbconn.getDatatable(sqlselect, "dbo.ai_table");
            return dt_kh;
        }
        public string ThuatToan_Size(string gender, string height, string weight, string foot_length)
        {
            try
            {
                DataTable data = loadData_AI();
                var codebook = new Codification(data);

                // Translate our training data into integer symbols using our codebook:
                DataTable symbols = codebook.Apply(data);
                int[][] inputs = symbols.ToArray<int>("gender", "height", "weight", "foot_length");
                int[] outputs = symbols.ToArray<int>("clothes_size");

        
                var id3learning = new ID3Learning()
                {
                    new DecisionVariable("gender",2),
                    new DecisionVariable("height", 20),  
                    new DecisionVariable("weight",20), 
                    new DecisionVariable("foot_length",20),

                };

                // Learn the training instances!
                DecisionTree tree = id3learning.Learn(inputs, outputs);

                // Compute the training error when predicting training instances
                double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

                // The tree can now be queried for new examples through 
                // its decide method. For example, we can create a query

                int[] query = codebook.Transform(new[,]
                {
                    {"gender", gender},
                    {"height", height},
                    {"weight", weight},
                    {"foot_length", foot_length},
                
                });

                // And then predict the label using
                int predicted = tree.Decide(query);  // result will be 0

                // We can translate it back to strings using
                string answer = codebook.Revert("clothes_size", predicted); // Answer will be: "No"
                return answer;
            }
            catch
            {
                MessageBox.Show("khong du doan dc size cua ban");
                return null;
            }
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            lb_answer.Text = ThuatToan_Size(txt_gender.Text, txt_height.Text, txt_weight.Text, txt_foot_lenght.Text);
        }

        private void fmr_AI_Goi_Y_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = loadData_AI();
        }
        public string ThuatToan_Giay(string foot_length,string gender)
        {
            try
            {
                DataTable data = loadData_AI();
                var codebook = new Codification(data);

                // Translate our training data into integer symbols using our codebook:
                DataTable symbols = codebook.Apply(data);
                int[][] inputs = symbols.ToJagged<int>("gender","foot_length");
                int[] outputs = symbols.ToArray<int>("shoe_size");


                var id3learning = new ID3Learning()
                {
                    new DecisionVariable("gender",2),
                    new DecisionVariable("foot_length",20),
                };

                // Learn the training instances!
                DecisionTree tree = id3learning.Learn(inputs, outputs);

                // Compute the training error when predicting training instances
                double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

                // The tree can now be queried for new examples through 
                // its decide method. For example, we can create a query

                int[] query = codebook.Transform(new[,]
                {
                    {"gender", gender},
                    {"foot_length", foot_length},
                
                });

                // And then predict the label using
                int predicted = tree.Decide(query);  // result will be 0

                // We can translate it back to strings using
                string answer = codebook.Revert("shoe_size", predicted); // Answer will be: "No"
                return answer;
            }
            catch
            {
                MessageBox.Show("khong du doan dc size cua ban");
                return null;
            }

        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            lb_answer.Text = ThuatToan_Giay(txt_foot_lenght.Text,txt_gender.Text);
        }
    }
}
