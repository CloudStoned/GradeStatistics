using StatsDLL;

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
    }
}