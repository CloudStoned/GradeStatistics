using StatsDLL;
using static System.Windows.Forms.AxHost;

namespace StatsWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Classroom.AddStudentsToList();
            LoadListView();

        }

        private void LoadListView()
        {
            foreach (StudentModel student in StudentModel.studentsList)
            {
                Console.WriteLine(student.studentName);
                string[] rows = { student.studentName };
                var listViewItems = new ListViewItem(rows);
                listView1.Items.Add(listViewItems);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pMean = MeanCalculator.CalculateMean(StudentModel.studentsList, stud => stud.prelim);
            double mMean = MeanCalculator.CalculateMean(StudentModel.studentsList, stud => stud.midterm);
            double fMean = MeanCalculator.CalculateMean(StudentModel.studentsList, stud => stud.finals);


            label1.Text = $"Prelim Mean: {pMean:F3}";
            label1.Visible = true;


            label2.Text = $"Midterm Mean: {mMean:F3}";
            label2.Visible = true;


            label3.Text = $"Finals Mean: {fMean:F3}";
            label3.Visible = true;
        }
    }
}