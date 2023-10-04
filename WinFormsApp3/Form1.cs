namespace WinFormsApp3
{

    public partial class Form1 : Form
    {
        public Point pointer { get; set; }
        public Form1()
        {

            InitializeComponent();

        }
   

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pointer = e.Location;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Button b1 = new Button();
            b1.Location = pointer;
            b1.Size = new Size(pointer.X,e.Location.Y-pointer.Y);
            Controls.Add(b1);

           
        }
    }
}