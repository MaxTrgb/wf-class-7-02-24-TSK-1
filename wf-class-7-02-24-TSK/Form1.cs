namespace wf_class_7_02_24_TSK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill in the blanks");
                return;
            }
            ListViewItem item = new ListViewItem(textBox1.Text);

            listView1.Items.Add(item);

            item.SubItems.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete");
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void changePriorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to change color");
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];

            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                item.BackColor = colorDialog.Color;
            }
        }
    }
}
