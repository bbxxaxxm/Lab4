namespace lab4
{
    public partial class Form1 : Form
    {
        List<double> grades = new List<double>();

        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Person gPA = new Person()
            {
                gpa = double.Parse(boxGPA.Text),

            };

            grades.Add(gPA.gpa);
            grades.Sort();
            boxMax.Text = grades.Last().ToString();
            boxMin.Text = grades.First().ToString();


          
            string input_name = boxname.Text;
            string input_year = boxyear.Text;
            int iYear = Int32.Parse(boxyear.Text);
            double GPA = double.Parse(boxGPA.Text);

            Person person = new Person(input_name, iYear, GPA);
            this.classroom.addPerson2Class(person);

            this.tbLishPerson.Text += person.getName() + "\r\n";
            this.classroom.showAllPersoninClass();

            int currentAge = Int32.Parse(this.tbTotal.Text);
            int newTotalAge = currentAge + person.getAge();
            this.tbTotal.Text = newTotalAge.ToString();

            boxAvg.Text = classroom.avgMaxGPA();
            boMaxName.Text = classroom.maxGPAName();
            boxMinName.Text = classroom.minGPAName();


        }
    }
    
        


        
    }
