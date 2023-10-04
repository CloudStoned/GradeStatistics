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
                string[] rows = { student.studentName, student.prelim.ToString(), student.midterm.ToString(), student.finals.ToString() };
                var listViewItems = new ListViewItem(rows);
                listView1.Items.Add(listViewItems);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prelim = MeanCalculator.CalculateMean(StudentModel.studentsList, stud => stud.prelim);
            double midterm = MeanCalculator.CalculateMean(StudentModel.studentsList, stud => stud.midterm);
            double finals = MeanCalculator.CalculateMean(StudentModel.studentsList, stud => stud.finals);


            label1.Text = $"Prelim Mean: {prelim:F3}";
            label1.Visible = true;


            label2.Text = $"Midterm Mean: {midterm:F3}";
            label2.Visible = true;


            label3.Text = $"Finals Mean: {finals:F3}";
            label3.Visible = true;
        }

        private void CalculateMedian_BTN_Click(object sender, EventArgs e)
        {
            double prelim = MedianCalculator.CalculateMedian(StudentModel.studentsList, stud => stud.prelim);
            double midterm = MedianCalculator.CalculateMedian(StudentModel.studentsList, stud => stud.midterm);
            double finals = MedianCalculator.CalculateMedian(StudentModel.studentsList, stud => stud.finals);


            label6.Text = $"Prelim Median: {prelim:F3}";
            label6.Visible = true;


            label5.Text = $"Midterm Median: {midterm:F3}";
            label5.Visible = true;


            label4.Text = $"Finals Median: {finals:F3}";
            label4.Visible = true;
        }

        private void CalculateMode_BTN_Click(object sender, EventArgs e)
        {
            double prelim = ModeCalculator.HasMode(StudentModel.studentsList, stud => stud.prelim);
            double midterm = ModeCalculator.HasMode(StudentModel.studentsList, stud => stud.midterm);
            double finals = ModeCalculator.HasMode(StudentModel.studentsList, stud => stud.finals);


            label9.Text = $"Prelim Mode: {prelim:F3}";
            label9.Visible = true;


            label8.Text = $"Midterm Mode: {midterm:F3}";
            label8.Visible = true;


            label7.Text = $"Finals Mode: {finals:F3}";
            label7.Visible = true;
        }
    }
}